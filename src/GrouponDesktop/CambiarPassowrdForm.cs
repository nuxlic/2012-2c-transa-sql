using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop
{
    public partial class CambiarPassowrdForm : Form
    {
        public string passwordAnterior{ get; set; }
        public int UserId { get; set; }
        public CambiarPassowrdForm(string passAnterior, int userId)
        {
            InitializeComponent();
            this.UserId = userId;
            this.passwordAnterior = passAnterior;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtPassAnterior.Text != this.passwordAnterior)
            {
                MessageBox.Show(this, "El password anterior que usted ingreso no coincide con el que usted tiene", "Error al cambiar Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtConfirmPass.Text != this.txtPassNuevo.Text)
            {
                MessageBox.Show(this, "Los passwords nuevos no coinicden", "Error al cambiar los passwords", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StringBuilder sentence = new StringBuilder().AppendFormat("UPDATE TRANSA_SQL.CuponeteUser SET Password='{0}' WHERE UserId={1}", new LoginApplication().encriptarPassword(this.txtPassNuevo.Text), this.UserId);
                Conexion.Instance.ejecutarQuery(sentence.ToString());
                MessageBox.Show(this, "Su contraseña ha sido actualizada", "Cambio de contraseña exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
