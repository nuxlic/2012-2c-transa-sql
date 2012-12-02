using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace GrouponDesktop.AbmProveedor
{
    public class SeleccionarForm : BusquedaForm
    {
        public SeleccionarForm()
        {
            base.btnModificar.HeaderText = "Seleccionar";
            
        }

        private string prov;

        public string Prov
        {
            get { return prov; }
            set { prov = value; }
        }
        protected override void BusquedaForm_Load(object sender, EventArgs e)
        {
           
            base.btnModificar.HeaderText = "Seleccionar";
           
        }

        protected override void dataGridView2_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                this.Prov=this.dataGridView2.CurrentRow.Cells["Cuit"].Value.ToString();
                MessageBox.Show("seleccionado con exito");
                this.Hide();
            }
        }
    }
}
