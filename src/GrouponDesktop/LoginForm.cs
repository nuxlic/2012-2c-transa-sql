using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Threading;
using System.Globalization;

namespace GrouponDesktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private LoginApplication Model = new LoginApplication();

        internal LoginApplication Model1
        {
            get { return Model; }
            set { Model = value; }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Model1.loguearse())
            {
                //solo para test
                this.Hide();
                AbmCliente.CreateCustomerForm form = new GrouponDesktop.AbmCliente.CreateCustomerForm();
                form.Show();
            }
        }

        private void cboxLanguaje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            Model1.Username1 = txtUserName.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Model1.Password1 = txtPassword.Text;
        }

    }
}
