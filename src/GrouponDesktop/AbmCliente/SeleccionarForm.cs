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
    public partial class SeleccionarForm : BusqElimCliente
    {
        public SeleccionarForm()
        {
            InitializeComponent();
            this.dataGridView2.Columns[0].HeaderText = "Seleccionar";
        }

        private string cliente;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        protected override void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex>= 0)
            {
                this.cliente = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
                MessageBox.Show("Seleccionado con exito");
                this.Close();
            }
        }

        protected override void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
