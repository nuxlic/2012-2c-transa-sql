using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.ComprarCupon
{
    public partial class CompraForm : Form
    {
        public CompraForm(DataGridViewRow row)
        {
            InitializeComponent();
            this.cuponRow = row;
        }

        private DataGridViewRow cuponRow;

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
