using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.CargaCredito
{
    public partial class cargarCredSobreClientecs : Form
    {
        public cargarCredSobreClientecs()
        {
            InitializeComponent();
            
        }
        private Conexion conn = Conexion.Instance;
        private CargaCreditoApplication model = null;
        private void clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder();
            sentence.Append("select c.CustomerId from TRANSA_SQL.Customer c where c.PhoneNumber=").Append(this.clientes.Text);
            DataTable table=conn.ejecutarQuery(sentence.ToString());
            this.model.CustomerId = Convert.ToString(table.Rows[0]["CustomerId"]);
        }

        private void cargarCredSobreClientecs_Load(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder();
            sentence.Append("select c.PhoneNumber from TRANSA_SQL.Customer c");
            DataTable clientes = conn.ejecutarQuery(sentence.ToString());
            for (int i=0; i < clientes.Rows.Count; i++)
            {
                this.clientes.Items.Add(clientes.Rows[i]["PhoneNumber"].ToString());
            }
            this.model = new CargaCreditoApplication(null);
            this.model.TipoPago = null;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            this.model.Monto = this.textBox1.Text;
            this.model.cargarCreditoOperation(null);
            MessageBox.Show("Se ha cargado el credito con exito, no dude en gastarlo!", "Operacion Finalizada con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.model.Monto = this.textBox1.Text;
        }
    }
}
