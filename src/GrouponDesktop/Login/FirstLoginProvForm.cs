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
    public partial class FirstLoginProvForm : AltaProvForm
    {

        public FirstLoginProvForm(DataRow row,MainForm mainW,int user)
        {
            InitializeComponent();
            //bindeos
            
            this.currentDataRow = row;
            this.mainWindow = mainW;
            this.corporateName.Text = this.currentDataRow[0].ToString();
            this.txt1 = this.corporateName.Text;
            this.Mail.Text = this.currentDataRow[1].ToString();
            this.txt2 = this.Mail.Text;
            this.Phone.Text = this.currentDataRow[2].ToString();
            this.txt3 = this.Phone.Text;
            this.address.Text = this.currentDataRow[3].ToString();
            this.txt4 = this.address.Text;
            this.postalCode.Text = this.currentDataRow[4].ToString();
            this.txt5 = this.postalCode.Text;
            this.City.Text = this.currentDataRow[5].ToString();
            this.txt6 = this.City.Text;
            this.Cuit.Text = this.currentDataRow[6].ToString();
            this.txt7 = this.Cuit.Text;
            this.entry.Text = this.currentDataRow[7].ToString();
            this.txt8 = this.entry.Text;
            
                this.ContactNumber.Text = this.currentDataRow[8].ToString();
                this.txt9 = this.ContactNumber.Text;
                
            this.userid = user;

        }

        public FirstLoginProvForm(DataRow row, MainForm mainW,int user,int perd)
        {
            InitializeComponent();
            //bindeos
            this.pd = perd;
            if (row == null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                row = dt.NewRow();
                insertar = true;
            }

            this.currentDataRow = row;
            this.mainWindow = mainW;
            this.corporateName.Text = this.currentDataRow[0].ToString();
            this.txt1 = this.corporateName.Text;
            this.Mail.Text = this.currentDataRow[1].ToString();
            this.txt2 = this.Mail.Text;
            this.Phone.Text = this.currentDataRow[2].ToString();
            this.txt3 = this.Phone.Text;
            this.address.Text = this.currentDataRow[3].ToString();
            this.txt4 = this.address.Text;
            this.postalCode.Text = this.currentDataRow[4].ToString();
            this.txt5 = this.postalCode.Text;
            this.City.Text = this.currentDataRow[5].ToString();
            this.txt6 = this.City.Text;
            this.Cuit.Text = this.currentDataRow[6].ToString();
            this.txt7 = this.Cuit.Text;
            this.entry.Text = this.currentDataRow[7].ToString();
            this.txt8 = this.entry.Text;

            this.ContactNumber.Text = this.currentDataRow[8].ToString();
            this.txt9 = this.ContactNumber.Text;

            this.userid = user;

        }





        private DataRow currentDataRow;
        private MainForm mainWindow;
        private int pd;
        private bool insertar = false;
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
           
        }

        public override void guardar_Click(object sender, EventArgs e)
        {
            if (this.Cuit.Text == "" || this.Cuit.Text == null || this.corporateName.Text == "" || this.corporateName.Text == null || this.Phone.Text=="" || this.Phone.Text==null)
            {
                MessageBox.Show("No debe dejar campos en blanco");
                return;
            }
            Conexion cnn = Conexion.Instance;
            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
            comando1.CommandType = CommandType.StoredProcedure;
           //bindeos 
            
            this.currentDataRow[0] = this.corporateName.Text;
            this.currentDataRow[1] = this.Mail.Text;
            this.currentDataRow[2] = this.Phone.Text;
            this.currentDataRow[3] = this.address.Text;
            this.currentDataRow[4] = this.postalCode.Text;
            this.currentDataRow[5] = this.City.Text;
            this.currentDataRow[6] = this.Cuit.Text;
            this.currentDataRow[7] = this.entry.Text;
            
                
                //se guardan los datos faltantes del proveedor
                this.currentDataRow[8] = this.ContactNumber.Text;
                if (insertar)
                {
                    StringBuilder ins = new StringBuilder().AppendFormat("insert into TRANSA_SQL.Supplier (UserId,PersonalDataId,CorporateName,Cuit) values ({0},{1},'{2}','{3}')", this.userid, this.pd, this.corporateName.Text, this.Cuit.Text);
                    Conexion.Instance.ejecutarQuery(ins.ToString());
                    
                }
                AbmProveedor.ModificarProvForm m = new AbmProveedor.ModificarProvForm(this.currentDataRow);
                m.UserId = this.userid;    
                m.Owner=this;
                m.Main=this.mainWindow;
                m.guardar_Click(sender, e);
                
                comando1.Parameters.Add("@userid", SqlDbType.Int);
                comando1.Parameters[0].Value =this.userid ;
                comando1.CommandText = "TRANSA_SQL.chauFirstLogin";
                cnn.ejecutarQueryConSP(comando1);    

                
            
           
            
           
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
