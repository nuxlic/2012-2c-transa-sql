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
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.ComprarCupon
{
    public partial class ComprarCuponForm : Form
    {
        public ComprarCuponForm(DataRow row)
        {
            InitializeComponent();
            this.userRow = row;


        }

        private ComprarCuponApp _model = new ComprarCuponApp();
        private DataRow userRow;
        public ComprarCuponApp Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private void ComprarCuponForm_Load(object sender, EventArgs e)
        {
            if (this.userRow["RoleId"].ToString() != "1")
            {
                this.label2.Visible = false;
                this.clientes.Visible = false;

                StringBuilder sent = new StringBuilder().AppendFormat("select * from TRANSA_SQL.Customer c where c.UserId={0}", this.userRow["UserId"].ToString());

               
                this.Model.Phone = Conexion.Instance.ejecutarQuery(sent.ToString()).Rows[0]["PhoneNumber"].ToString();
                //

                int dia = Convert.ToInt32(ConfigurationManager.AppSettings.Get(0));
                int mes = Convert.ToInt32(ConfigurationManager.AppSettings.Get(1));
                int anio = Convert.ToInt32(ConfigurationManager.AppSettings.Get(2));
                this.Model.Fecha = new SqlDateTime(anio, mes, dia);
                this.dataGridView1.DataSource = this.Model.cargarCupones();
                this.dataGridView1.Columns[1].Visible = false;
                this.dataGridView1.Columns[6].Visible = false;
                this.dataGridView1.Columns[7].Visible = false;

                this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)//lo engrampamos y compro un cupon
            {
                
              CompraForm  c =new CompraForm(this.dataGridView1);
              c.Owner = this;
              c.Show();
            }
        }

        private void clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Model.Phone = this.clientes.Text;


            int dia = Convert.ToInt32(ConfigurationManager.AppSettings.Get(0));
            int mes = Convert.ToInt32(ConfigurationManager.AppSettings.Get(1));
            int anio = Convert.ToInt32(ConfigurationManager.AppSettings.Get(2));
            this.Model.Fecha = new SqlDateTime(anio, mes, dia);
            this.dataGridView1.DataSource = this.Model.cargarCupones();
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[7].Visible = false;

            this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
