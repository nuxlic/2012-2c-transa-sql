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
    public partial class BusquedaElimProvForm : BusquedaForm
    {
        public BusquedaElimProvForm()
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
                new ElimProvApp(this.dataGridView2.CurrentRow).darDeBaja();
            }
        }
    }
}
