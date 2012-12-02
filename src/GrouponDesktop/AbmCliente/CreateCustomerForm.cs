using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.AbmCliente
{
    public partial class CreateCustomerForm : Form
    {
        private CreateCustomerApplication appModel = new CreateCustomerApplication();
        public CreateCustomerForm()
        {
            InitializeComponent();
        }

        private void CreateCustomerForm_Load(object sender, EventArgs e)
        {
            List<string> strings = this.appModel.getCitys();
            for (int i = 0; i < strings.Count; i++)
            {
                this.chkBoxListPreferences.Items.Add(strings[i]);    
            }
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            List<string> citys = new List<string>();

            foreach (string item in this.chkBoxListPreferences.CheckedItems)
            {
                citys.Add(item.Trim());
            }

            bool retValue = this.appModel.createCustomer(this.txtName.Text, this.txtSurname.Text, this.txtDni.Text, this.txtEmail.Text, this.txtPhone.Text, this.txtAddress.Text, this.txtPostalCode.Text, this.dtpBirhtday.Value, citys);

            if (retValue)
            {
                MessageBox.Show("Alta exitosa", "Alta de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.appModel.validarSoloLetras(e);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.appModel.validarSoloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.appModel.validarSoloNumeros(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.appModel.validarMail(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.appModel.validarSoloNumeros(e);
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.appModel.validarSoloLetrasYnumeros(e);
        }

        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.appModel.validarSoloLetrasYnumeros(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPhone.Text = "";
            this.txtEmail.Text = "";
            this.txtName.Text = "";
            this.txtDni.Text = "";
            this.txtAddress.Text = "";
            this.txtPostalCode.Text = "";
            this.txtSurname.Text = "";
        }
    }
}
