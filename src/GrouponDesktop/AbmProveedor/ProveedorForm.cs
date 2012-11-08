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
    public partial class ProveedorForm : Form
    {
        public ProveedorForm()
        {
            InitializeComponent();
        }

        private void ProveedorForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmProveedor.AltaProveedorForm().Show();
        }
    }
}
