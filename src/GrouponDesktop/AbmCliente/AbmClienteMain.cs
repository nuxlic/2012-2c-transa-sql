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
    public partial class AbmClienteMain : Form
    {
        public AbmClienteMain(string tipouser)
        {
            InitializeComponent();
            this.tipoUsr = tipouser;
        }

        private string tipoUsr;
        private MainFormApplication model = new MainFormApplication();

        private void AbmClienteMain_Load(object sender, EventArgs e)
        {
            List<int> permisos = this.model.GetPermission(this.tipoUsr);
            if (permisos.Any(unPermiso => unPermiso == 4))
            {
                this.btnAlta.Visible = true;
            }
            if (permisos.Any(unPermiso => unPermiso == 5))
            {
                this.btnBaja.Visible = true;
            }
            if (permisos.Any(unPermiso => unPermiso == 6))
            {
                this.btnModificacion.Visible = true;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            BusqModifCliente busqModifCliente = new BusqModifCliente();
            this.Hide();
            busqModifCliente.ShowDialog();
            this.Show();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            CreateCustomerForm createCustomer = new CreateCustomerForm();
            this.Hide();
            createCustomer.ShowDialog();
            this.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            BusqElimCliente busqElimCliForm = new BusqElimCliente();
            this.Hide();
            busqElimCliForm.ShowDialog();
            this.Show();
        }
    }
}
