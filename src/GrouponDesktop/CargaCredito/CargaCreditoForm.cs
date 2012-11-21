using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.Exeptions;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.CargaCredito
{
    public partial class CargaCreditoForm : Form
    {
        private DataRow _Usuario;
        private CargaCreditoApplication _model;

        internal CargaCreditoApplication Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public DataRow Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }


        public CargaCreditoForm(DataRow userRow)
        {
            InitializeComponent();
            this.Usuario = userRow;
        }

        private void CargaCreditoForm_Load(object sender, EventArgs e)
        {
            this.Model = new CargaCreditoApplication(Usuario);            
        }

        private void FormaPagoComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Model.TipoPago = this.FormaPagoComBox.Text;
        }

        private void MontoACargarTxtBox_TextChanged(object sender, EventArgs e)
        {
            this.Model.Monto=this.MontoACargarTxtBox.Text;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            string payTipe=null;
            if (Convert.ToInt32(this.MontoACargarTxtBox.Text) < 15)
            {
                MessageBox.Show("Error CN23: Usted es un rata. Debe cargar mas de 15 sopes sino nos fundimos. Disculpe las Molestias ", "Error!! No sea Rata cargue mas de 15 sopes!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    StringBuilder busqueda = new StringBuilder().Append("select * from TRANSA_SQL.PaymentType pt where pt.Name='").Append(this.FormaPagoComBox.Text.TrimStart("Tarjeta ".ToCharArray())).Append("'");
                    DataTable table = Conexion.Instance.ejecutarQuery(busqueda.ToString());
                    payTipe = Convert.ToString(table.Rows[0]["PaymentTypeId"]);
                    if (this.FormaPagoComBox.Text == "Tarjeta Debito" || this.FormaPagoComBox.Text == "Tarjeta Crédito")
                    {
                        payTipe=this.Model.getOrSetTarjeta();
                    }
                    this.Model.cargarCreditoOperation(payTipe);
                    MessageBox.Show("Se ha cargado el credito con exito, no dude en gastarlo!", "Operacion Finalizada con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Owner.Show();
                    this.Close();
                }
                catch (NoTenesTarjetaUachoExeption ex)
                {
                    new TargetaForm(this,this.Model,payTipe).Show();
                    
                    //this.Owner.Show();
                }
            }

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

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
