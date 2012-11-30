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
    public partial class PedirDevolucionForm : Form
    {
        public PedirDevolucionForm()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            //meter logica aca
            this.Hide();
            DevolverForm d = new DevolverForm();
            d.Owner = this.Owner;
            d.Show();
        }
    }
}
