using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.AbmCliente;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.Login
{
    public partial class FirstLoginClienteForm : Form
    {
        private AbmCliente.ModifClienteApp model;
        public int Dni { get; set; }
        public string prevDni { get; set; }
        public string prevPhone { get; set; }
        public int userId { get; set; }
        private MainForm main;

        public FirstLoginClienteForm(DataRow row,MainForm m,int userId)
        {
            InitializeComponent();
            this.main = m;
            this.Dni = Int32.Parse(row["Dni"].ToString());
            this.model = new AbmCliente.ModifClienteApp(row);
            List<string> citys = this.model.getCitys();
            List<string> checkedCitys = this.model.getCheckedCitys(this.Dni);
            this.userId = userId;
            //Bindeos...
            this.txtName.Text = this.model.Nombre;
            this.txtSurname.Text = this.model.Apellido;
            this.txtDni.Text = this.model.Dni;
            this.txtEmail.Text = this.model.Mail;
            this.txtPhone.Text = this.model.Phone;
            this.txtAddress.Text = this.model.Address;
            this.txtPostalCode.Text = this.model.PostalCode;
            this.dtpBirhtday.Value = DateTime.Parse(this.model.FechaNac);
            this.prevDni = this.txtDni.Text;
            this.prevPhone = this.txtPhone.Text;

            for (int i = 0; i < citys.Count; i++)
            {
                int index = this.chkBoxListPreferences.Items.Add(citys[i]);
                if (checkedCitys.Any(city => city == citys[i]))
                {
                    this.chkBoxListPreferences.SetItemChecked(index, true);
                }
            }
            //StringBuilder sentece = new StringBuilder();
            //sentece.AppendFormat("SELECT C.UserId FROM TRANSA_SQL.Customer C WHERE C.PhoneNumber={0}", this.txtPhone.Text);
            //this.userId = (int)Conexion.Instance.ejecutarQuery(sentece.ToString()).Rows[0][0];

            //StringBuilder sentece2 = new StringBuilder();
            //sentece2.AppendFormat("SELECT CU.Enabled, CU.Deleted FROM TRANSA_SQL.CuponeteUser CU WHERE CU.UserId={0}", this.userId);
            //DataRow rowUser = Conexion.Instance.ejecutarQuery(sentece2.ToString()).Rows[0];
            
        }

        private int pd;
        private bool insertar=false;

        public FirstLoginClienteForm(DataRow row, MainForm m, int userId,int perd)
        {
            InitializeComponent();
            this.main = m;
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
                row = dt.NewRow();
                insertar = true;
            }
            else
            {
                this.Dni = Int32.Parse(row["Dni"].ToString());

            } this.model = new AbmCliente.ModifClienteApp(row);
            List<string> citys = this.model.getCitys();
            List<string> checkedCitys = this.model.getCheckedCitys(this.Dni);
            this.userId = userId;
            //Bindeos...
            this.txtName.Text = this.model.Nombre;
            this.txtSurname.Text = this.model.Apellido;
            this.txtDni.Text = this.model.Dni;
            this.txtEmail.Text = this.model.Mail;
            this.txtPhone.Text = this.model.Phone;
            this.txtAddress.Text = this.model.Address;
            this.txtPostalCode.Text = this.model.PostalCode;
            if (this.model.FechaNac != null&&this.model.FechaNac!="")
            {this.dtpBirhtday.Value = DateTime.Parse(this.model.FechaNac);
            }
            
            this.prevDni = this.txtDni.Text;
            this.prevPhone = this.txtPhone.Text;

            for (int i = 0; i < citys.Count; i++)
            {
                int index = this.chkBoxListPreferences.Items.Add(citys[i]);
                if (checkedCitys.Any(city => city == citys[i]))
                {
                    this.chkBoxListPreferences.SetItemChecked(index, true);
                }
            }
            //StringBuilder sentece = new StringBuilder();
            //sentece.AppendFormat("SELECT C.UserId FROM TRANSA_SQL.Customer C WHERE C.PhoneNumber={0}", this.txtPhone.Text);
            //this.userId = (int)Conexion.Instance.ejecutarQuery(sentece.ToString()).Rows[0][0];

            //StringBuilder sentece2 = new StringBuilder();
            //sentece2.AppendFormat("SELECT CU.Enabled, CU.Deleted FROM TRANSA_SQL.CuponeteUser CU WHERE CU.UserId={0}", this.userId);
            //DataRow rowUser = Conexion.Instance.ejecutarQuery(sentece2.ToString()).Rows[0];

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
            StringBuilder sentece = new StringBuilder();
            sentece.AppendLine("Los siguientes campos poseen registros existentes");
            bool valid;
            if (this.txtDni.Text != "" && this.prevDni != this.txtDni.Text && new CreateCustomerApplication().validarDni(Int64.Parse(this.txtDni.Text)) || this.txtPhone.Text != "" && this.prevPhone != this.txtPhone.Text && new CreateCustomerApplication().validarTelefono(Int64.Parse(this.txtPhone.Text)))
            {
                if (this.prevDni != this.txtDni.Text && new CreateCustomerApplication().validarDni(Int64.Parse(this.txtDni.Text)))
                {
                    sentece.AppendLine("Dni");
                }

                if (this.prevPhone != this.txtPhone.Text && new CreateCustomerApplication().validarTelefono(Int64.Parse(this.txtPhone.Text)))
                {
                    sentece.AppendLine("Telefono");
                }
                valid = true;
            }
            else
            {
                this.model.Nombre = this.txtName.Text;
                this.model.Apellido = this.txtSurname.Text;
                this.model.Dni = this.txtDni.Text;
                this.model.Mail = this.txtEmail.Text;
                this.model.Phone = this.txtPhone.Text;
                this.model.Address = this.txtAddress.Text;
                this.model.PostalCode = this.txtPostalCode.Text;
                this.model.FechaNac = this.dtpBirhtday.Value.ToString();
                this.model.userId = this.userId.ToString();
                if (this.chkBoxListPreferences.CheckedItems.Count > 0)
                {
                    if (this.txtName.Text == "" || this.txtEmail.Text == "" || this.txtDni.Text == "" || this.txtAddress.Text == "" || this.txtPhone.Text == "" || this.txtPostalCode.Text == "" || this.txtSurname.Text == "")
                    {
                        MessageBox.Show(this, "No pueden haber campos vacios", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (insertar)
                        {
                            StringBuilder ins = new StringBuilder().AppendFormat("insert into TRANSA_SQL.Customer (UserId,PersonalDataId,Dni,PhoneNumber) values ({0},{1},{2},{3})", this.userId, this.pd, this.model.Dni, this.model.Phone);
                            Conexion.Instance.ejecutarQuery(ins.ToString());
                            this.model.userId = Convert.ToString(this.userId);
                        }
                        this.model.modificar();

                        List<string> citys = new List<string>();
                        foreach (string item in this.chkBoxListPreferences.CheckedItems)
                        {
                            citys.Add(item.Trim());
                        }

                        this.model.setCitys(citys);
                        Conexion cnn = Conexion.Instance;
                        System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
                        comando1.CommandType = CommandType.StoredProcedure;
                        comando1.Parameters.Add("@userid", SqlDbType.Int);
                        comando1.Parameters[0].Value = this.userId;
                        comando1.CommandText = "TRANSA_SQL.chauFirstLogin";
                        cnn.ejecutarQueryConSP(comando1);
                        this.main.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Debe tener seleccionada por lo menos 1 ciudad", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                valid = false;
            }

            if (valid)
            {
                MessageBox.Show(sentece.ToString());
            }
        }
       

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloLetras(e);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloNumeros(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarMail(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloNumeros(e);
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloLetrasYnumeros(e);
        }

        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloLetrasYnumeros(e);
        }

       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtAddress.Text = "";
            this.txtDni.Text = "";
            this.txtEmail.Text = "";
            this.txtName.Text = "";
            this.txtPhone.Text = "";
            this.txtPostalCode.Text = "";
            this.txtSurname.Text = "";
            for (int i = 0; i < this.chkBoxListPreferences.Items.Count; i++)
            {
                this.chkBoxListPreferences.SetItemChecked(i, false);
            }
        }

        private void FirstLoginClienteForm_Load(object sender, EventArgs e)
        {
            if (this.txtAddress.Text != null && this.txtAddress.Text != "")
            {
                this.txtAddress.Enabled = false;
            }
            if (this.txtDni.Text != null && this.txtDni.Text != "")
            {
                this.txtDni.Enabled = false;
            }
            if (this.txtEmail.Text != null && this.txtEmail.Text != "")
            {
                this.txtEmail.Enabled = false;
            }
            if (this.txtName.Text != null && this.txtName.Text != "")
            {
                this.txtName.Enabled = false;
            }
            if (this.txtPhone.Text != null && this.txtPhone.Text != "")
            {
                this.txtPhone.Enabled = false;
            }
            if (this.txtPostalCode.Text != null && this.txtPostalCode.Text != "")
            {
                this.txtPostalCode.Enabled = false;
            }
            if (this.txtSurname.Text != null && this.txtAddress.Text != "")
            {
                this.txtSurname.Enabled = false;
            }
            if (this.model.FechaNac != null && this.model.FechaNac != "")
            {
                this.dtpBirhtday.Enabled = false;
            }
            if (this.chkBoxListPreferences.CheckedItems.Count != 0)
            {
                this.chkBoxListPreferences.Enabled = false;
            }
        }

       

        

    }
}
