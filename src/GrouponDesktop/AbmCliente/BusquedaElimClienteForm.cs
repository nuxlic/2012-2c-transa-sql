using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.AbmProveedor;

namespace GrouponDesktop.AbmCliente
{
    public partial class BusquedaElimClienteForm : BusquedaForm
    {
        public BusquedaElimClienteForm()
        {
            InitializeComponent();
            DataGridViewButtonColumn btnDarBaja = new DataGridViewButtonColumn();
            btnDarBaja.Name = "Dar Baja";
            this.dataGridView2.Columns.RemoveAt(0);
            this.dataGridView2.Columns.Add(btnDarBaja);
        }

        protected override void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                new ElimClienteApp(this.dataGridView2.CurrentRow).darDeBaja();
            }
        }

        private void BusquedaElimClienteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
