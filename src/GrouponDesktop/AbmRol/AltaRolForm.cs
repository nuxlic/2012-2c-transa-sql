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

namespace GrouponDesktop.AbmRol
{
    public partial class AltaRolForm : Form
    {
        private AltaRolApp model = new AltaRolApp();
        public AltaRolForm()
        {
            InitializeComponent();
        }

        private void AltaRolForm_Load(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT P.Name FROM TRANSA_SQL.Permission P");
            DataTable tabla = Conexion.Instance.ejecutarQuery(sentence.ToString());
            foreach (DataRow row in tabla.Rows)
            {
                this.lstBoxPermisos.Items.Add(row[0].ToString());
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetras(e);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.lstBoxPermisos.ClearSelected();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT * FROM TRANSA_SQL.Role R WHERE R.Name='{0}'", this.txtNombre.Text);
            if (this.txtNombre.Text == "" || this.lstBoxPermisos.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "No pueden haber campos vacios", "Error en alta de rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows.Count > 0)
            {
                MessageBox.Show(this, "El Rol ya existe", "Error en alta de rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<string> permisos = new List<string>();
                foreach ( var item in this.lstBoxPermisos.SelectedItems)
	            {
		            permisos.Add(item.ToString());
            	}
                this.model.crearRol(this.txtNombre.Text, permisos);
                MessageBox.Show(this, "El Rol ha sido dado de alta con exito", "Alta de rol exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
