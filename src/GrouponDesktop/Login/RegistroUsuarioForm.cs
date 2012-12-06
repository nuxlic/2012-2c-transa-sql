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
using System.Security.Cryptography;

namespace GrouponDesktop.Login
{
    public partial class RegistroUsuarioForm : Form
    {
        public RegistroUsuarioForm()
        {   
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistroUsuarioForm_Load(object sender, EventArgs e)
        {
            this.cmbTipoUsr.Items.Add("Cliente");
            this.cmbTipoUsr.Items.Add("Proveedor");
            this.cmbTipoUsr.SelectedIndex = 0;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloLetrasYnumeros(e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.txtConfirmarPassword.Text == "" || this.txtPassword.Text == "" || this.txtUsername.Text == "")
            {
                MessageBox.Show(this, "No pueden haber campos vacios", "Error en Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtPassword.Text == this.txtConfirmarPassword.Text)
            {
                StringBuilder checkUser = new StringBuilder();
                checkUser.AppendFormat("SELECT * FROM TRANSA_SQL.CuponeteUser CU WHERE CU.Username='{0}'", this.txtUsername.Text);
                int userRows = Conexion.Instance.ejecutarQuery(checkUser.ToString()).Rows.Count;
                if (userRows == 0)
                {
                    int userTypeId;
                    int roleId;
                    if ((this.cmbTipoUsr.SelectedItem as string) == "Cliente")
                    {
                        userTypeId = 2;
                        roleId = 2;
                    }
                    else
                    {
                        userTypeId = 3;
                        roleId = 3;
                    }

                    string password = new LoginApplication().encriptarPassword(this.txtPassword.Text);
                    
                    StringBuilder sentece = new StringBuilder();
                    sentece.AppendFormat("INSERT INTO TRANSA_SQL.CuponeteUser(Username, Password, FirstLogin, FailedAttemps, RoleId, Enabled, Deleted, UserTypeId) VALUES ('{0}','{1}',0,0,{2},1,0, '{3}')", this.txtUsername.Text, password, roleId, userTypeId);
                    Conexion.Instance.ejecutarQuery(sentece.ToString());

                    StringBuilder sentece2 = new StringBuilder();
                    sentece2.AppendFormat("SELECT TOP 1 CU.UserId FROM TRANSA_SQL.CuponeteUser CU ORDER BY CU.UserId DESC");
                    int newUserId = (int)Conexion.Instance.ejecutarQuery(sentece2.ToString()).Rows[0][0];

                    if (userTypeId == 2)
                    {
                        RegistrarCliente registrarCliente = new RegistrarCliente(newUserId);
                        registrarCliente.ShowDialog();
                        this.Close();
                    }
                    else if (userTypeId == 3)
                    {
                        RegristrarProveedor registrarProveedor = new RegristrarProveedor(newUserId);
                        registrarProveedor.ShowDialog();
                        this.Close();
                    }
                }

                else
                {
                    MessageBox.Show(this, "El nombre de usuario ya existe", "Error en Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Los passwords ingresados no coinciden", "Error en Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
