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
        public CompraForm(DataGridView tabla)
        {
            InitializeComponent();
            this.cuponRow = tabla.CurrentRow;
            this.grilla = tabla;
        }

        private DataGridViewRow cuponRow;
        private DataGridView grilla;
        private ComprarCuponForm _owner;
        
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            
            _owner = (ComprarCuponForm)this.Owner;
            this._owner.Model.CouponRow = this.cuponRow;
            if ((int)this.cantidad.Value <= 0)
            {
                MessageBox.Show("Debe elegir una cantidad positiva");
            }
            else if ((int)this.cantidad.Value > Convert.ToDecimal(this.cuponRow.Cells[6].Value))
            {
                MessageBox.Show("No hay stock");
            }
            else if (this.cuponRow.Cells[7].Value!=DBNull.Value)
            {
                if ((int)this.cantidad.Value > Convert.ToDecimal(this.cuponRow.Cells[7].Value))
                {
                    MessageBox.Show("No puede comprar tanta cantidad de un mismo cupon");
                }
            }
            else
            {
                this._owner.Model.comprar((int)this.cantidad.Value);
                this.grilla.DataSource = this._owner.Model.cargarCupones();
                this.Close();

            }
        }
    }
}
