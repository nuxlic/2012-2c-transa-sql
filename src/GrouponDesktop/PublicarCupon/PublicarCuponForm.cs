using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlTypes;
using System.Configuration;

namespace GrouponDesktop.PublicarCupon
{
    public partial class PublicarCuponForm : Form
    {
        public PublicarCuponForm()
        {
            InitializeComponent();
        }

        private PublicarCuponApp _model = new PublicarCuponApp();
        private AbmProveedor.SeleccionarForm s = new GrouponDesktop.AbmProveedor.SeleccionarForm();
        public PublicarCuponApp Model
        {
            get { return _model; }
            set { _model = value; }
        }
        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PublicarCuponForm_Load(object sender, EventArgs e)
        {
            this.Model.Proveedor = null;
            int dia = Convert.ToInt32(ConfigurationManager.AppSettings.Get(0));
            int mes = Convert.ToInt32(ConfigurationManager.AppSettings.Get(1));
            int anio = Convert.ToInt32(ConfigurationManager.AppSettings.Get(2));
            SqlDateTime date = new SqlDateTime(anio, mes, dia);
            this.dateTimePicker1.Value = date.Value;
            this.Model.Fecha = date;
            this.dataGridView1.DataSource = this.Model.buscar();
            this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dataGridView1.Columns[2].Visible = false;
            this.Provselecc.Text = s.RazonSoc;
        }

        private void selec_Click(object sender, EventArgs e)
        {
            s.Txt = this.Provselecc;
            s.Show();
            
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            this.Provselecc.Text = s.RazonSoc;
            this.Model.Proveedor = s.Prov;
            this.dataGridView1.DataSource = this.Model.buscar();
            this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Provselecc_TextChanged(object sender, EventArgs e)
        {
            this.Provselecc.Text = s.RazonSoc;
        }

        private void pub_Click(object sender, EventArgs e)
        {
            if (this.Model.Publicables.Count == 0)
            {
                MessageBox.Show("Debe seleccionar alguno");
            }
            else
            {
                this.Model.publicar();
                MessageBox.Show("Se han publicado con exito");
                this.dataGridView1.DataSource = this.Model.buscar();
                this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                
            }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == 0 && e.RowIndex >= 0)
        //    {
        //        if (Convert.ToBoolean(this.dataGridView1.CurrentRow.Cells["Publicar"].Value))
        //        {
        //            this.Model.Publicables.Add(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["CouponBookId"].Value.ToString()));
        //        }
        //        else
        //        {
        //            this.Model.Publicables.Remove(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["CouponBookId"].Value.ToString()));
        //        }
        //    }
        //}

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(this.dataGridView1.CurrentRow.Cells["Publicar"].Value))
                {
                    this.Model.Publicables.Add(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["CouponBookId"].Value.ToString()));
                }
                else
                {
                    this.Model.Publicables.Remove(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["CouponBookId"].Value.ToString()));
                }
            }
        }
    }
}
