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
            DataTable tabla = Conexion.Instance.ejecutarQuery(sender.ToString());
            foreach (DataRow row in tabla.Rows)
            {
                this.lstBoxPermisos.Items.Add(row[0].ToString());
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetras(e);
        }
    }
}
