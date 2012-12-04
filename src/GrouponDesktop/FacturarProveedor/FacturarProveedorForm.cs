using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.FacturarProveedor
{
    public partial class FacturarProveedorForm : Form
    {
        public FacturarProveedorForm()
        {
            InitializeComponent();
        }

        private AbmProveedor.SeleccionarForm s = new GrouponDesktop.AbmProveedor.SeleccionarForm();
        private FacturarProveedorApp _model = new FacturarProveedorApp();

        public FacturarProveedorApp Model
        {
            get { return _model; }
            set { _model = value; }
        }
        private void selec_Click(object sender, EventArgs e)
        {
            s.Txt = this.Provselecc;
            s.Show();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            //bindeos
            this.Model.Proveedor = s.Prov;
            this.Model.Fecha1 = this.dateTimePicker1.Value;
            this.Model.Fecha2 = this.dateTimePicker2.Value;
            this.dataGridView1.DataSource = this.Model.buscar();
            this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            if (this.Model.Proveedor != null && this.Model.Proveedor != "")
            {
                this.dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[1].Visible = false;
            }
            if (this.dataGridView1.Rows.Count == 0)
            {
                this.fNro.Text = "Sin Numero";
                this.importe.Text = "$0";
                this.total.Text = "$0";
            }
            else
            {
                this.fNro.Text = Convert.ToString(this.Model.getNumero());
                this.importe.Text ="$"+ Convert.ToString(this.Model.getImporte(this.dataGridView1)/2);
                this.total.Text = "$" + Convert.ToString(this.Model.getImporte(this.dataGridView1));
            }
        }
    }
}
