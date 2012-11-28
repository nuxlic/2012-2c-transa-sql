using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.AbmProveedor;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.Login
{
    public partial class FirstLoginForm : AltaProvForm
    {

        public FirstLoginForm(DataRow row,MainForm mainW,int rol)
        {
            //bindeos
            this.currentDataRow = row;
            this.mainWindow = mainW;
            this.tipoRol = rol;
            this.corporateName.Text = this.currentDataRow[0].ToString();//dni
            this.Mail.Text = this.currentDataRow[1].ToString();//mail
            this.Phone.Text = this.currentDataRow[2].ToString();//telefono
            this.address.Text = this.currentDataRow[3].ToString();//direccion
            this.postalCode.Text = this.currentDataRow[4].ToString();//codigo postal
            this.City.Text = this.currentDataRow[5].ToString();//nombre
            this.Cuit.Text = this.currentDataRow[6].ToString();//apellido
            this.entry.Text = this.currentDataRow[7].ToString();//fecha nac
            if (rol == 3)
            {
                this.ContactNumber.Text = this.currentDataRow[8].ToString();
            }
            else
            {
                this.label2.Text = "Dni";
                this.label7.Text = "Nombre";
                this.label8.Text = "Apellido";
                this.label10.Text = "Fecha nacimiento";
                this.label9.Hide();
                this.ContactNumber.Hide();
            }
        }

        private DataRow currentDataRow;
        private MainForm mainWindow;
        private int tipoRol;

        protected override void AltaProvForm_Load(object sender, EventArgs e)
        {
            this.Text = "";
            base.label1.Text = "";
            base.label1.Text = "Ingrese los datos faltantes";
        }

        public override void guardar_Click(object sender, EventArgs e)
        {
            Conexion cnn = Conexion.Instance;
            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
            comando1.CommandType = CommandType.StoredProcedure;
            
            if (tipoRol == 3)
            {
                //bindeos
                this.currentDataRow[0] = this.corporateName.Text;
                this.currentDataRow[1] = this.Mail.Text;
                this.currentDataRow[2] = this.Phone.Text;
                this.currentDataRow[3] = this.address.Text;
                this.currentDataRow[4] = this.postalCode.Text;
                this.currentDataRow[5] = this.City.Text;
                this.currentDataRow[6] = this.Cuit.Text;
                this.currentDataRow[7] = this.entry.Text;
                this.currentDataRow[8] = this.ContactNumber.Text;
                new AbmProveedor.ModificarProvForm(this.currentDataRow).guardar_Click(sender, e);

                comando1.Parameters.Add("@username", SqlDbType.NVarChar);
                comando1.Parameters[0].Value = this.Cuit;
                comando1.CommandText = "TRANSA_SQL.chauFirstLogin";
                cnn.ejecutarQueryConSP(comando1);    

                this.mainWindow.Show();
            }
            else
            {
                
            }
            this.Close();
           
        }
    }
}
