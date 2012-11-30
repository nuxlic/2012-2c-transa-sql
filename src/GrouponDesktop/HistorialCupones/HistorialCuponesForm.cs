using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.HistorialCupones
{
    public partial class HistorialCuponesForm : Form
    {
        public HistorialCuponesForm(DataRow row)
        {
            InitializeComponent();
            this.userRow = row;
        }

        private DataRow userRow;
        private HistorialApp _model = new HistorialApp();

        public HistorialApp Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private void HistorialCuponesForm_Load(object sender, EventArgs e)
        {
            if (this.userRow["Username"].ToString() != "admin")
            {
                this.Model.Phone = this.userRow["Username"].ToString();
                this.label2.Visible = false;
                this.clientes.Visible = false;
            }
            else
            {
                StringBuilder sentence = new StringBuilder();
                sentence.Append("select c.PhoneNumber from TRANSA_SQL.Customer c");
                DataTable clientes = Conexion.Instance.ejecutarQuery(sentence.ToString());
                for (int i = 0; i < clientes.Rows.Count; i++)
                {
                    this.clientes.Items.Add(clientes.Rows[i]["PhoneNumber"].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            progressBar1.Value = 0;
            progressBar1.Step = 50;
            progressBar1.PerformStep();
            this.Model.Fecha1 = this.dateTimePicker1.Value;
            this.Model.Fecha2 = this.dateTimePicker2.Value;
            this.dataGridView1.DataSource = this.Model.mostrarhistorial();
            this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            progressBar1.PerformStep();
        }

        private void clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Model.Phone = this.clientes.Text;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
