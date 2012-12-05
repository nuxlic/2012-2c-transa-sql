using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.Login
{
    public partial class RegistrarCliente : Form
    {
        private RegistroClienteApp model;
        public RegistrarCliente(int userId)
        {
            InitializeComponent();
            model = new RegistroClienteApp(userId);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.txtAddress.Text == "" || this.txtDni.Text == "" || this.txtEmail.Text == "" || this.txtName.Text == "" || this.txtPhone.Text == "" || this.txtPostalCode.Text == "" || this.txtSurname.Text == "" || this.chkBoxListPreferences.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "No pueden haber campos vacios ni ciudades seleccionadas", "Error en Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<string> citys = new List<string>();

                foreach (string item in this.chkBoxListPreferences.CheckedItems)
                {
                    citys.Add(item.Trim());
                }

                if(this.model.registerCustomer(this.txtName.Text, this.txtSurname.Text, this.txtDni.Text, this.txtEmail.Text, this.txtPhone.Text, this.txtAddress.Text, this.txtPostalCode.Text, this.dtpBirhtday.Value,citys))
                {
                    MessageBox.Show(this, "El registro se ha realizado con exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {
            List<string> citys = this.model.getCitys();
            foreach (string city in citys)
            {
                this.chkBoxListPreferences.Items.Add(city);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtAddress.Text = "";
            this.txtName.Text = "";
            this.txtDni.Text = "";
            this.txtEmail.Text = "";
            this.txtPhone.Text = "";
            this.txtPostalCode.Text = "";
            this.txtSurname.Text = "";
            
            
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetras(e);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloNumeros(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarMail(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloNumeros(e);
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetrasYnumeros(e);
        }

        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetrasYnumeros(e);
        }
    }
}
