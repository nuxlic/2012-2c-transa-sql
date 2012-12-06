using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop
{
    public partial class AbmMain : Form
    {
        public AbmMain(int roleId)
        {
            InitializeComponent();
            this.RoleId = roleId;
        }
        private int RoleId;

        private MainFormApplication model = new MainFormApplication();
        private void AbmMain_Load(object sender, EventArgs e)
        {
            List<int> permisos = this.model.GetPermission(this.RoleId);
            if (permisos.Any(unPermiso => unPermiso == 1 || unPermiso == 2 || unPermiso == 3))
            {
                this.btnAbmRol.Visible=true;
            }
            if (permisos.Any(unPermiso => unPermiso == 4 || unPermiso == 5 || unPermiso == 6 ))
            {
                this.btnCliente.Visible=true;
            }
            if (permisos.Any(unPermiso => unPermiso == 7 || unPermiso == 8 || unPermiso == 9))
            {
                this.btnProveedor.Visible=true;
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnAbmRol_Click(object sender, EventArgs e)
        {
            new GrouponDesktop.AbmRol.AbmRolMain(this.RoleId).Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            new GrouponDesktop.AbmCliente.AbmClienteMain(this.RoleId).Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            new GrouponDesktop.AbmProveedor.AbmProveedorMain(this.RoleId).Show();
        }
    }
}
