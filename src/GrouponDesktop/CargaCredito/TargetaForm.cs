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
    public partial class TargetaForm : Form
    {
        public TargetaForm(CargaCreditoForm ownerForm)
        {
            InitializeComponent();
            this.Owner1 = ownerForm;

        }

        private CargaCreditoForm _owner;

        public CargaCreditoForm Owner1
        {
            get { return _owner; }
            set { _owner = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TargetaForm_Load(object sender, EventArgs e)
        {
            this.label1.Text += this.Owner1.Model.TipoPago;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder cardtype = new StringBuilder().Append("select * from TRANSA_SQL.CardType ct where ct.Name=").Append("'").Append(this.Owner1.Model.TipoPago.TrimStart("Tarjeta ".ToCharArray())).Append("'");
            DataTable table = Conexion.Instance.ejecutarQuery(cardtype.ToString());
            string cardtypeId = Convert.ToString(table.Rows[0]["CardTypeId"]);
            StringBuilder card = new StringBuilder().Append("insert into TRANSA_SQL.Card values (").Append(this.Owner1.Model.CustomerId).Append(", ").Append(this.textBox1.Text).Append(", ").Append(cardtypeId).Append(")");
            Conexion.Instance.ejecutarQuery(card.ToString());
            this.Owner1.Model.cargarCreditoOperation();
            MessageBox.Show("Se ha cargado el credito con exito, no dude en gastarlo!", "Operacion Finalizada con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            this.Owner1.Owner.Show();
            this.Owner1.Close();
        }
    }
}
