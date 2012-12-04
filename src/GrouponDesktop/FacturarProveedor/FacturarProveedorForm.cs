using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.FacturarProveedor
{
    public partial class FacturarProveedorForm : Form
    {
        public FacturarProveedorForm()
        {
            InitializeComponent();
        }

        private AbmProveedor.SeleccionarForm s = new GrouponDesktop.AbmProveedor.SeleccionarForm();

        private void selec_Click(object sender, EventArgs e)
        {
            s.Txt = this.Provselecc;
            s.Show();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
