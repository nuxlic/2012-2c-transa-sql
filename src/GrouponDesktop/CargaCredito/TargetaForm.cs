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
        public TargetaForm(Form ownerF,CargaCreditoApplication model, string payType)
        {
            InitializeComponent();
            this.Model = model;
            this.payT = payType;
            this.own = ownerF;
        }

        private CargaCreditoApplication _model;
        private Form own = null;
        internal CargaCreditoApplication Model
        {
            get { return _model; }
            set { _model = value; }
        }
        private string payT;

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TargetaForm_Load(object sender, EventArgs e)
        {
            this.label1.Text += this.Model.TipoPago;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder cardtype = new StringBuilder().Append("select * from TRANSA_SQL.CardType ct where ct.Name=").Append("'").Append(this.Model.TipoPago.TrimStart("Tarjeta ".ToCharArray())).Append("'");
            DataTable table = Conexion.Instance.ejecutarQuery(cardtype.ToString());
            string cardtypeId = Convert.ToString(table.Rows[0]["CardTypeId"]);
            StringBuilder card = new StringBuilder().Append("insert into TRANSA_SQL.Card values (").Append(this.Model.CustomerId).Append(", ").Append(this.textBox1.Text).Append(", ").Append(cardtypeId).Append(")");
            Conexion.Instance.ejecutarQuery(card.ToString());
          /*  if (payT == null)
            {
                StringBuilder busqueda = new StringBuilder().Append("select * from TRANSA_SQL.Card c join TRANSA_SQL.CardType ct on c.CardTypeId=ct.CardTypeId join TRANSA_SQL.PaymentType pt on pt.Name=ct.Name where c.CustomerId=").Append(this.Owner1.Model.CustomerId).Append(" and ct.Name='").Append(this.Owner1.Model.TipoPago.TrimStart("Tarjeta ".ToCharArray())).Append("'");
                DataTable tar = Conexion.Instance.ejecutarQuery(busqueda.ToString());
                payT = tar.Rows[0]["PaymentTypeId"].ToString();
            }*/
            this.Model.cargarCreditoOperation(payT);
            MessageBox.Show("Se ha cargado el credito con exito, no dude en gastarlo!", "Operacion Finalizada con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            //this.Owner1.Owner.Show();
            this.own.Close();
        }
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void comboBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            e.Handled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
