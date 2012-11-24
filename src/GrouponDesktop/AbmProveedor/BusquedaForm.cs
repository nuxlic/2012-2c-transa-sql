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
            this.model.loadForm();
        }

        private BusquedaApp model = new BusquedaApp();

        private void Buscar_Click(object sender, EventArgs e)
        {
            this.model.Cuit = this.txtCuit.Text;
            this.model.Mail = this.txtMail.Text;
            this.model.RazonSoc = this.txtCorporateName.Text;
            List<DataRow> rows = this.model.buscar();
            if (rows.Count > 0)
            {
                foreach (DataRow row in rows)
                {

                    this.dataGridView1.Rows.Add(row.ItemArray);

                }
            }
        }

        

        

        
    }
}
