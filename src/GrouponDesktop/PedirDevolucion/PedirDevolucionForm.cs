using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.Commons.Database;
using System.Data.SqlTypes;
using System.Configuration;

namespace GrouponDesktop.PedirDevolucion
{
    public partial class PedirDevolucionForm : Form
    {
        public PedirDevolucionForm(DataRow row)
        {
            InitializeComponent();
            this.userRow = row;
            this.Model.CouponCode = this.cupon.Text;
            if ((int)this.userRow["RoleId"] != 1)
            {
                this.label3.Hide();
                this.comboBox1.Hide();
                StringBuilder sent = new StringBuilder().AppendFormat("select * from TRANSA_SQL.Customer c where c.UserId={0}", this.userRow["UserId"].ToString());


                this.Model.Phone = Conexion.Instance.ejecutarQuery(sent.ToString()).Rows[0]["PhoneNumber"].ToString();
            }
            else
            {
                this.Model.Phone = this.comboBox1.Text;
            }
            int dia = Convert.ToInt32(ConfigurationManager.AppSettings.Get(0));
            int mes = Convert.ToInt32(ConfigurationManager.AppSettings.Get(1));
            int anio = Convert.ToInt32(ConfigurationManager.AppSettings.Get(2));
            this.Model.Fecha = new SqlDateTime(anio, mes, dia);
        }

        private DataRow userRow;
        private PedirDevApp _model = new PedirDevApp();

        public PedirDevApp Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            this.Model.CouponCode = this.cupon.Text;
            if (this.Model.Phone == "" || this.Model.Phone == null || this.Model.CouponCode == null || this.Model.CouponCode == "")
            {
                MessageBox.Show("Complete los datos faltantes");
            }
            else
            {
                DataRow row = this.Model.bindear();
                if (row != null)
                {
                    this.Hide();
                    DevolverForm d = new DevolverForm(row, this.Model);
                    d.Owner = this.Owner;
                    d.Show();
                }
            }
        }

        private void PedirDevolucionForm_Load(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder();
            sentence.Append("select c.PhoneNumber from TRANSA_SQL.Customer c");
            DataTable clientes = Conexion.Instance.ejecutarQuery(sentence.ToString());
            for (int i = 0; i < clientes.Rows.Count; i++)
            {
                this.comboBox1.Items.Add(clientes.Rows[i]["PhoneNumber"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Model.Phone = this.comboBox1.Text;

        }

        private void cupon_KeyPress(object sender, KeyPressEventArgs e)
        {
            new AbmProveedor.AltaProvApp().validarSoloLetrasYnumeros(e);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
