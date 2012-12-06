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

        public FirstLoginForm(DataRow row,MainForm mainW,int userTypeId,int user)
        {
            InitializeComponent();
            //bindeos
            this.currentDataRow = row;
            this.mainWindow = mainW;
            this.userType = userTypeId;
            this.corporateName.Text = this.currentDataRow[0].ToString();//dni
            this.txt1 = this.corporateName.Text;
            this.Mail.Text = this.currentDataRow[1].ToString();//mail
            this.txt2 = this.Mail.Text;
            this.Phone.Text = this.currentDataRow[2].ToString();//telefono
            this.txt3 = this.Phone.Text;
            this.address.Text = this.currentDataRow[3].ToString();//direccion
            this.txt4 = this.address.Text;
            this.postalCode.Text = this.currentDataRow[4].ToString();//codigo postal
            this.txt5 = this.postalCode.Text;
            this.City.Text = this.currentDataRow[5].ToString();//nombre
            this.txt6 = this.City.Text;
            this.Cuit.Text = this.currentDataRow[6].ToString();//apellido
            this.txt7 = this.Cuit.Text;
            this.entry.Text = this.currentDataRow[7].ToString();//fecha nac
            this.txt8 = this.entry.Text;
            if (userTypeId == 3)//es proveedor
            {
                this.ContactNumber.Text = this.currentDataRow[8].ToString();
                this.txt9 = this.ContactNumber.Text;
                this.label11.Hide();
                this.dateTimePicker1.Hide();
            }
            else
            {
                //coloco los labels para tipo de usuario cliente
                this.label2.Text = "Dni";
                this.label7.Text = "Nombre";
                this.label8.Text = "Apellido";
                this.label10.Hide();
                this.label9.Hide();
                this.ContactNumber.Hide();
                this.entry.Hide();
                this.dateTimePicker1.Text = this.currentDataRow[7].ToString();
                this.txt10 = this.dateTimePicker1.Value.ToString();
                     
            }
            this.userid = user;

        }

        private DataRow currentDataRow;
        private MainForm mainWindow;
        private int userType;
        private int userid;
        private string txt1;
        private string txt2;
        private string txt3;
        private string txt4;
        private string txt5;
        private string txt6;
        private string txt7;
        private string txt8;
        private string txt9;
        private string txt10;

        protected override void AltaProvForm_Load(object sender, EventArgs e)
        {
            this.Text = "";
            base.label1.Text = "";
            base.label1.Text = "Ingrese los datos faltantes";
            if (txt1 != null && txt1 != "")
            {
                this.corporateName.Enabled = false;
            }
            if (txt2 != null && txt2 != "")
            {
                this.Mail.Enabled = false;
            }
            if (txt3 != null && txt3 != "")
            {
                this.Phone.Enabled = false;
            }
            if (txt4 != null && txt4 != "")
            {
                this.address.Enabled = false;
            }
            if (txt5 != null && txt5 != "")
            {
                this.postalCode.Enabled = false;
            }
            if (txt6 != null && txt6 != "")
            {
                this.City.Enabled = false;
            }
            if (txt7 != null && txt7 != "")
            {
                this.Cuit.Enabled = false;
            }
            if (txt8 != null && txt8 != "")
            {
                this.entry.Enabled = false;
            }
            if (txt9 != null && txt9 != "")
            {
                this.ContactNumber.Enabled = false;
            }
            if (txt10 != null && txt10 != "")
            {
                this.dateTimePicker1.Enabled = false;
            }

        }

        public override void guardar_Click(object sender, EventArgs e)
        {
            Conexion cnn = Conexion.Instance;
            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
            comando1.CommandType = CommandType.StoredProcedure;
           //bindeos 
            this.currentDataRow[0] = this.corporateName.Text; //dni
            this.currentDataRow[1] = this.Mail.Text;//mail
            this.currentDataRow[2] = this.Phone.Text;//telefono
            this.currentDataRow[3] = this.address.Text;//direccion
            this.currentDataRow[4] = this.postalCode.Text;//codigo postal
            this.currentDataRow[5] = this.City.Text;// nombre
            this.currentDataRow[6] = this.Cuit.Text;//apellido
            this.currentDataRow[7] = this.entry.Text;// fecha nac
            if (this.userType == 3)//es proveedor
            {
                
                //se guardan los datos faltantes del proveedor
                this.currentDataRow[8] = this.ContactNumber.Text;
                AbmProveedor.ModificarProvForm m = new AbmProveedor.ModificarProvForm(this.currentDataRow);
                m.Owner=this;
                m.Main=this.mainWindow;
                m.guardar_Click(sender, e);
                
                comando1.Parameters.Add("@userid", SqlDbType.Int);
                comando1.Parameters[0].Value =this.userid ;
                comando1.CommandText = "TRANSA_SQL.chauFirstLogin";
                cnn.ejecutarQueryConSP(comando1);    

                
            }
            else //es cliente
            {
                //se guardan los datos faltantes del cliente
                AbmCliente.ModifClienteApp c = new AbmCliente.ModifClienteApp(this.currentDataRow);
                c.userId = null;
                c.Owner = this;
                c.Main = this.mainWindow;
                c.modificar();
                comando1.Parameters.Add("@userid", SqlDbType.NVarChar);
                comando1.Parameters[0].Value = this.userid;
                comando1.CommandText = "TRANSA_SQL.chauFirstLogin";
                cnn.ejecutarQueryConSP(comando1);
            }
            //this.mainWindow.Show();
            //this.Close();
           
        }

        public override void Limpiar_Click(object sender, EventArgs e)
        {
            if (this.corporateName.Enabled) this.corporateName.Text = "";
            if (this.Mail.Enabled) this.Mail.Text = "";
            if (this.Phone.Enabled) this.Phone.Text = "";
            if (this.address.Enabled) this.address.Text = "";
            if (this.postalCode.Enabled) this.postalCode.Text = "";
            if (this.City.Enabled) this.City.Text = "";
            if (this.Cuit.Enabled) this.Cuit.Text = "";
            if (this.entry.Enabled) this.entry.Text = "";
            if (this.ContactNumber.Enabled) this.ContactNumber.Text = "";
        }        
    }
}
