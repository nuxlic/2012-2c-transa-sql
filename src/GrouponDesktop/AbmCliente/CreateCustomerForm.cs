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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkBoxListPreferences_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if (this.txtPhone.Text.Length == 0)
                errorProvider1.SetError(this.txtPhone, "El numero de telefono no puede ser nulo");
            else
            {

                List<string> citys = new List<string>();
                foreach (string item in this.chkBoxListPreferences.CheckedItems)
                {
                    citys.Add(item.Trim());
                }
                
                bool response = this.appModel.createCustomer(this.txtName.Text, this.txtSurname.Text, this.txtDni.Text, this.txtEmail.Text, this.txtPhone.Text, this.txtAddress.Text, this.txtPostalCode.Text, this.dtpBirhtday.Value, citys);
                if (!response)
                    MessageBox.Show("Ocurrio un error al registrar los datos", "Alta de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Alta exitosa", "Alta de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
