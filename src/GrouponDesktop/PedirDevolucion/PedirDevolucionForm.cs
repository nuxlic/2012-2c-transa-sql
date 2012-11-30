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
        public PedirDevolucionForm(DataRow row)
        {
            InitializeComponent();
            this.userRow = row;
            this.Model.CouponCode = this.cupon.Text;
        }

        private DataRow userRow;
        private PedirDevApp _model = new PedirDevApp();

        public PedirDevApp Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            DataRow row = this.Model.bindear();
            this.Hide();
            DevolverForm d = new DevolverForm();
            d.Owner = this.Owner;
            d.Show();
        }
    }
}
