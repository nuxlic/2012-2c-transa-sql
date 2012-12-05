using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.ComprarGiftCard
{
    public partial class SeleccionarForm : AbmCliente.BusqElimCliente
    {
        public SeleccionarForm()
        {
            InitializeComponent();
            this.dataGridView2.Columns[0].HeaderText = "Seleccionar";
            this.txtDni.Visible = false;
            this.label5.Visible = false;

        }

        private string cliente;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        protected override void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                this.cliente = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
                MessageBox.Show("Seleccionado con exito");
                this.Close();
            }
        }

        protected override void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if ((this.txtName.Text == null || this.txtName.Text == "") && (this.txtMail.Text == null || this.txtMail.Text == "") && (this.txtApellido.Text == null || this.txtApellido.Text == ""))
            {
                MessageBox.Show("Error: Debe al menos completar un filtro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Conexion cnn = Conexion.Instance;

                System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

                comando1.CommandType = CommandType.StoredProcedure;
                int contador = 0;
                if (this.txtApellido.Text != null && this.txtApellido.Text != "")
                {
                    comando1.Parameters.Add("@apellido", SqlDbType.NVarChar);
                    comando1.Parameters[contador].Value = this.txtApellido.Text;
                    contador++;
                }

                if (this.txtName.Text != null && this.txtName.Text != "")
                {
                    comando1.Parameters.Add("@nombre", SqlDbType.NVarChar);
                    comando1.Parameters[contador].Value = this.txtName.Text;
                    contador++;
                }

                if (this.txtMail.Text != null && this.txtMail.Text != "")
                {
                    comando1.Parameters.Add("@mail", SqlDbType.NVarChar);
                    comando1.Parameters[contador].Value = this.txtMail.Text;
                    contador++;
                }



                comando1.CommandText = "TRANSA_SQL.filtrarClienteParaGift";

                tabla = cnn.ejecutarQueryConSP(comando1);
                this.dataGridView2.DataSource = tabla;
                this.dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }
    }
}
