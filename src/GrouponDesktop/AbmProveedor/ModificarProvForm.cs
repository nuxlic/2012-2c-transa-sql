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

        private DataGridViewRow currentRow;

        override
        protected void guardar_Click(object sender, EventArgs e)
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

                MessageBox.Show("El Proveedor ha sido modificado con exito");

                this.Close();
            }
        }
    }
}
