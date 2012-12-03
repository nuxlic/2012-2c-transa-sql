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
        }
    }
}
