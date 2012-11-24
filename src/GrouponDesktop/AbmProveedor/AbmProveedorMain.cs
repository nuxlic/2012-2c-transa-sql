using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.AbmProveedor
{
    public partial class AbmProveedorMain : Form
    {
        public AbmProveedorMain(string tipouser)
        {
            InitializeComponent();
            this.tipoUsr = tipouser;
        }

        private string tipoUsr;
        private MainFormApplication model = new MainFormApplication();

        private void AbmProveedorMain_Load(object sender, EventArgs e)
        {
            List<int> permisos = this.model.GetPermission(this.tipoUsr);
            if (permisos.Any(unPermiso => unPermiso == 7))
            {
                this.btnAlta.Visible = true;
            }
            if (permisos.Any(unPermiso => unPermiso == 8))
            {
                this.btnBaja.Visible = true;
            }
            if (permisos.Any(unPermiso => unPermiso == 9))
            {
                this.btnModificacion.Visible = true;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaProvForm alta = new AltaProvForm();
            alta.Owner = this;
            alta.Show();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            new BusquedaForm().Show();
        }
    }
}
