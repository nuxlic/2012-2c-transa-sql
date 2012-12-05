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
    public partial class BusqElimCliente : Form
    {
        public BusqElimCliente()
        {
            InitializeComponent();
        }

        private BusquedaApp model = new BusquedaApp();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnBuscar_Click(object sender, EventArgs e)
        {
            this.model.Dni = this.txtDni.Text;
            this.model.Mail = this.txtMail.Text;
            this.model.Nombre = this.txtName.Text;
            this.model.Apellido = this.txtApellido.Text;
            this.dataGridView2.DataSource = this.model.buscar();
            this.dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtApellido.Text = "";
            this.txtName.Text = "";
            this.txtMail.Text = "";
            this.txtDni.Text = "";
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloNumeros(e);
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarMail(e);
        }

        protected virtual void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                new ElimClienteApp(this.dataGridView2.CurrentRow).darDeBaja();
            }
        }

        protected virtual void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
