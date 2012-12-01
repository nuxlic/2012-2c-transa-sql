using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlTypes;

namespace GrouponDesktop.PedirDevolucion
{
    public partial class DevolverForm : Form
    {
        public DevolverForm(DataRow row,PedirDevApp model)
        {
            InitializeComponent();
            this.desc.Text = row["CouponDescription"].ToString();
            this.venc.Text = row["ConsumptionMaturityDate"].ToString();
            this.pfict.Text = row["FictitiousPrice"].ToString();
            this.preal.Text = row["RealPrice"].ToString();
            this.mod = model;
        }

        private PedirDevApp mod;
        private void DevolverForm_Load(object sender, EventArgs e)
        {
            this.desc.Enabled = false;
            this.venc.Enabled = false;
            this.preal.Enabled = false;
            this.pfict.Enabled = false;

        }

        private void si_Click(object sender, EventArgs e)
        {
            if (this.Razon.Text != "" && this.Razon != null)
            {
                SqlDateTime d = new SqlDateTime(Convert.ToInt32(this.venc.Text.Split('/')[2].Split(' ')[0]), Convert.ToInt32(this.venc.Text.Split('/')[1]), Convert.ToInt32(this.venc.Text.Split('/')[0]));
                if (this.mod.Fecha.CompareTo(d) > 0)
                {
                    MessageBox.Show("Paso la fecha limite para devolucion");
                    this.Owner.Show();
                    this.Close();
                }
                else
                {
                    this.mod.devolver(this.Razon.Text);
                    this.Owner.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("debe escribir una razon");
            }
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Razon_KeyPress(object sender, KeyPressEventArgs e)
        {
            new AbmProveedor.AltaProvApp().validarSoloLetrasYnumeros(e);
        }
    }
}
