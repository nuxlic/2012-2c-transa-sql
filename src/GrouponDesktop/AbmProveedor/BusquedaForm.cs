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

        

        

        
    }
}
