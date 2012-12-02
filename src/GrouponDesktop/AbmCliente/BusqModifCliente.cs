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
    public partial class BusqModifCliente : BusqElimCliente
    {
        public BusqModifCliente()
        {
            InitializeComponent();
            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn();
            btnModificar.Name = "Modificar";
            this.dataGridView2.Columns.RemoveAt(0);
            this.dataGridView2.Columns.Add(btnModificar);
        }

        protected override void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                ModifCliente modifCliente = new ModifCliente(this.dataGridView2.CurrentRow);
                this.Hide();
                modifCliente.ShowDialog();
                this.Show();
            }

        }

        private void BusqModifCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
