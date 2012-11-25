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
using GrouponDesktop.Exeptions;


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
            try
            {
                string tipo = Model1.loguearse();
                MainForm menu = new MainForm(this, tipo);
                menu.Owner = this;
                menu.Show();
                this.Hide();
            }
            catch (AccesoNoConcedidoExeption ex)
            {
                this.errorProvider1.SetError(this.txtUserName, "Usuario o Password incorrecto");
                this.errorProvider1.SetError(this.txtPassword, "Usuario o Password incorrecto");
            }
            catch (UsuarioBloqueadoExeption ex)
            {
                MessageBox.Show("Error 678: El usuario esta bloqueado por haber tenido 3 intentos fallidos de autenticacion. Contacte al administrador", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
            catch (UsuarioDadoDeBajaExeption ex)
            {
                MessageBox.Show("Error: El usuario se encuentra dado de baja. Contacte al administrador", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void cboxLanguaje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            
                Model1.Username = txtUserName.Text;
            
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Model1.Password = txtPassword.Text;
        }

        private void gBoxLogin_Enter(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            new Login.RegistroUsuarioForm(this).Show();
            this.Hide();

        }

    }
}
