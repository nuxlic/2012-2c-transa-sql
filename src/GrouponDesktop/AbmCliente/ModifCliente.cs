using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.AbmCliente
{
    public partial class ModifCliente : Form
    {
        private ModifClienteApp model;
        public int Dni { get; set; }
        public string prevDni { get; set; }
        public string prevPhone { get; set; }
        public int userId { get; set; }
        

        public ModifCliente(DataGridViewRow row)
        {
            InitializeComponent();
            this.Dni = Int32.Parse(row.Cells["Dni"].Value.ToString());
            this.model = new ModifClienteApp(row);
            List<string> citys = this.model.getCitys();
            List<string> checkedCitys = this.model.getCheckedCitys(this.Dni);
            
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
            StringBuilder sentece = new StringBuilder();
            sentece.AppendFormat("SELECT C.UserId FROM TRANSA_SQL.Customer C WHERE C.PhoneNumber={0}", this.txtPhone.Text);
            this.userId = (int)Conexion.Instance.ejecutarQuery(sentece.ToString()).Rows[0][0];

            StringBuilder sentece2 = new StringBuilder();
            sentece2.AppendFormat("SELECT CU.Enabled, CU.Deleted FROM TRANSA_SQL.CuponeteUser CU WHERE CU.UserId={0}", this.userId);
            DataRow rowUser = Conexion.Instance.ejecutarQuery(sentece2.ToString()).Rows[0];
            if ((bool)rowUser[0])
            {
                this.btnDesbloquear.Visible = false;
            } 
            if(!(bool)rowUser[1])
            {
                this.btnHabilitar.Visible = false;
            }
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
                        this.model.modificar();

                        List<string> citys = new List<string>();
                        foreach (string item in this.chkBoxListPreferences.CheckedItems)
                        {
                            citys.Add(item.Trim());
                        }

                        this.model.setCitys(citys);

                        this.Dispose();
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void ModifCliente_Load(object sender, EventArgs e)
        {

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
