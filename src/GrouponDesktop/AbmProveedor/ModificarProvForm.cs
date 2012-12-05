using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.AbmProveedor
{
    public partial class ModificarProvForm : AltaProvForm
    {
        public ModificarProvForm(DataGridViewRow row)
        {
            InitializeComponent();
            this.currentRow = row;
            this.corporateName.Text = this.currentRow.Cells[1].Value.ToString();
            this.Mail.Text = this.currentRow.Cells[2].Value.ToString();
            this.Phone.Text = this.currentRow.Cells[3].Value.ToString();
            this.address.Text = this.currentRow.Cells[4].Value.ToString();
            this.postalCode.Text = this.currentRow.Cells[5].Value.ToString();
            this.City.Text = this.currentRow.Cells[6].Value.ToString();
            this.Cuit.Text = this.currentRow.Cells[7].Value.ToString();
            this.entry.Text = this.currentRow.Cells[8].Value.ToString();
            this.ContactNumber.Text = this.currentRow.Cells[9].Value.ToString();
        }

        public ModificarProvForm(DataRow row)
        {
            InitializeComponent();
            this.currentDataRow = row;
            this.corporateName.Text = this.currentDataRow[0].ToString();
            this.Mail.Text = this.currentDataRow[1].ToString();
            this.Phone.Text = this.currentDataRow[2].ToString();
            this.address.Text = this.currentDataRow[3].ToString();
            this.postalCode.Text = this.currentDataRow[4].ToString();
            this.City.Text = this.currentDataRow[5].ToString();
            this.Cuit.Text = this.currentDataRow[6].ToString();
            this.entry.Text = this.currentDataRow[7].ToString();
            this.ContactNumber.Text = this.currentDataRow[8].ToString();
        }

        private DataGridViewRow currentRow;
        private DataRow currentDataRow;
        private MainForm _main;//solo para first Login

        public MainForm Main
        {
            get { return _main; }
            set { _main = value; }
        }

        private int userId;

        override
        public void guardar_Click(object sender, EventArgs e)
        {
            if (this.City.Text == null || this.City.Text == "" || this.postalCode.Text == null || this.postalCode.Text == "" || this.Cuit.Text == null || this.Cuit.Text == "" || this.address.Text == null || this.address.Text == "" || this.Mail.Text == null || this.Mail.Text == "" || this.ContactNumber.Text == null || this.ContactNumber.Text == "" || this.corporateName.Text == null || this.corporateName.Text == "" || this.entry.Text == null || this.entry.Text == "" || this.Phone.Text == null || this.Phone.Text == "")
            {
                MessageBox.Show("Error: No debe dejar campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                Conexion cnn = Conexion.Instance;

                System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

                comando1.CommandType = CommandType.StoredProcedure;
                int contador = 0;

                comando1.Parameters.Add("@cuit", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.Cuit.Text;
                contador++;

                comando1.Parameters.Add("@UserId", SqlDbType.Int);
                comando1.Parameters[contador].Value = this.userId;
                contador++;


                comando1.Parameters.Add("@razonSoc", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.corporateName.Text;
                contador++;

                comando1.Parameters.Add("@mail", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.Mail.Text;
                contador++;

                comando1.Parameters.Add("@phone", SqlDbType.Decimal);
                comando1.Parameters[contador].Precision = 18;
                comando1.Parameters[contador].Scale = 0;
                comando1.Parameters[contador].Value = this.Phone.Text;
                contador++;

                comando1.Parameters.Add("@addr", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.address.Text;
                contador++;

                comando1.Parameters.Add("@postalCode", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.postalCode.Text;
                contador++;

                comando1.Parameters.Add("@city", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.City.Text;
                contador++;

                comando1.Parameters.Add("@entry", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.entry.Text;
                contador++;

                comando1.Parameters.Add("@contact", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.ContactNumber.Text;
                contador++;

                comando1.CommandText = "TRANSA_SQL.modificarProveedor";


                cnn.ejecutarQueryConSP(comando1);

                MessageBox.Show("Los datos han sido cargados con exito");

                if (this.Main != null && this.Owner != null)
                {
                    this.Main.Show();
                    this.Owner.Close();
                }

                this.Close();
            }
        }

        private void ModificarProvForm_Load(object sender, EventArgs e)
        {
            StringBuilder sentece = new StringBuilder();
            sentece.AppendFormat("SELECT C.UserId FROM TRANSA_SQL.Supplier C WHERE C.Cuit='{0}'", this.Cuit.Text);
            this.userId = (int)Conexion.Instance.ejecutarQuery(sentece.ToString()).Rows[0][0];

            StringBuilder sentece2 = new StringBuilder();
            sentece2.AppendFormat("SELECT CU.Enabled, CU.Deleted FROM TRANSA_SQL.CuponeteUser CU WHERE CU.UserId={0}", this.userId);
            DataRow rowUser = Conexion.Instance.ejecutarQuery(sentece2.ToString()).Rows[0];
            if ((bool)rowUser[0])
            {
                this.btnDesbloquear.Visible = false;
            }
            if (!(bool)rowUser[1])
            {
                this.btnHabilitar.Visible = false;
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            StringBuilder sentece = new StringBuilder();
            sentece.AppendFormat("UPDATE TRANSA_SQL.CuponeteUser SET Deleted=0 WHERE UserId={0}", this.userId);
            Conexion.Instance.ejecutarQuery(sentece.ToString());
            MessageBox.Show(this, "El usuario que habia sido dado de baja fue habilitado correctamente", "Habilitar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.btnHabilitar.Visible = false;
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            StringBuilder sentece = new StringBuilder();
            sentece.AppendFormat("UPDATE TRANSA_SQL.CuponeteUser SET Enabled=1 WHERE UserId={0}", this.userId);
            Conexion.Instance.ejecutarQuery(sentece.ToString());
            MessageBox.Show(this, "El usuario que habia sido bloqueado se desbloqueo correctamente", "Desbloquear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.btnDesbloquear.Visible = false;
        }
    }
}
