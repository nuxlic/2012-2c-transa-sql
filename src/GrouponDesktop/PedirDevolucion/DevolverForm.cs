using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.PedirDevolucion
{
    public partial class DevolverForm : Form
    {
        public DevolverForm()
        {
            InitializeComponent();
        }

        private void DevolverForm_Load(object sender, EventArgs e)
        {
            this.desc.Enabled = false;
            this.venc.Enabled = false;
            this.preal.Enabled = false;
            this.pfict.Enabled = false;

        }

        private void si_Click(object sender, EventArgs e)
        {
            //meter logica aca
            this.Owner.Show();
            this.Close();
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
