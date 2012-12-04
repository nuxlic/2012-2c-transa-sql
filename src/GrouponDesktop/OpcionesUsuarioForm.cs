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
    public partial class OpcionesUsuarioForm : Form
    {
        private int UserId { get; set; }
        public bool Bajado { get; set; }
        public string password { get; set; }

        public OpcionesUsuarioForm(string username, string password)
        {
            InitializeComponent();
            StringBuilder sentece = new StringBuilder().AppendFormat("SELECT CU.UserId FROM TRANSA_SQL.CuponeteUser CU WHERE CU.Username='{0}'", username);
            this.UserId = (int)Conexion.Instance.ejecutarQuery(sentece.ToString()).Rows[0][0];
            this.password = password;
        }

        private void btnDarseDeBaja_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Esta seguro que desea darse de baja, si hace click en Si no podra volver a loguearse a menos que un administrador le de el alta nuevamente", "Darse de baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                StringBuilder sentence = new StringBuilder().AppendFormat("UPDATE TRANSA_SQL.CuponeteUser SET Deleted=1 WHERE UserId={0}", this.UserId);
                Conexion.Instance.ejecutarQuery(sentence.ToString());
                MessageBox.Show(this, "Gracias por haber usado nuestros servicios, esperamos verlo nuevamente.", "Usuario dado de baja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Bajado = true;
                this.Dispose();
            }
            else
            {
                this.Bajado = false;
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Bajado = false;
            this.Dispose();
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            CambiarPassowrdForm cambiarPassword = new CambiarPassowrdForm(this.password, this.UserId);
            this.Hide();
            cambiarPassword.ShowDialog();
            this.Show();
        }
    }
}
