using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.ListadoEstadistico
{
    public partial class Top5Form : Form
    {
        public Top5Form(IListadoModel m,int sem,int anio,string encabezado)
        {
            InitializeComponent();
            this.Model = m;
            this.Semestre = sem;
            this.Anio = anio;
            if (encabezado != null)
            {
                this.label1.Text = encabezado;
            }
        }

        private IListadoModel _model;
        private int _semestre;

        public int Semestre
        {
            get { return _semestre; }
            set { _semestre = value; }
        }
        private int _anio;

        public int Anio
        {
            get { return _anio; }
            set { _anio = value; }
        }

        public IListadoModel Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private void Top5Form_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.Model.listar(this.Semestre, this.Anio);
            this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
