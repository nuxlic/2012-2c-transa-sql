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
    public partial class BusquedaForm : Form
    {
        public BusquedaForm()
        {
            InitializeComponent();
            
        }

        private BusquedaApp model = new BusquedaApp();

        private void Buscar_Click(object sender, EventArgs e)
        {
            this.model.Cuit = this.txtCuit.Text;
            this.model.Mail = this.txtMail.Text;
            this.model.RazonSoc = this.txtCorporateName.Text;
            this.dataGridView2.DataSource = this.model.buscar();
            this.dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void txtCorporateName_KeyPress(object sender, KeyPressEventArgs e)
        {
            new AltaProvApp().validarSoloLetrasYnumeros(e);
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            new AltaProvApp().validarCuit(e);
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            new AltaProvApp().validarMail(e);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.txtCorporateName.Text = null;
            this.txtCuit.Text = null;
            this.txtMail.Text = null;
            this.dataGridView2.DataSource = null;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                new ModificarProvForm(this.dataGridView2.CurrentRow).Show();
            }
        }

        

        

        
    }
}
