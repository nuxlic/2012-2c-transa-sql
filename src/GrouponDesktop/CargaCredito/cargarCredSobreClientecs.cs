using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.Commons.Database;
using GrouponDesktop.Exeptions;

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

        internal CargaCreditoApplication Model
        {
            get { return model; }
            set { model = value; }
        }
        
        private void cargarCredSobreClientecs_Load(object sender, EventArgs e)
        {
            
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
            this.model.TipoPago = this.comboBox1.Text;
            

            string payTipe = null;
            if (this.comboBox1.Text == "" || this.textBox1.Text == "" || s.Cliente == ""||s.Cliente==null)
            {
                MessageBox.Show("Error: Debe completar los campos en blanco ", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (Convert.ToInt64(this.textBox1.Text) < 15)
                {
                    MessageBox.Show("Error CN23: Usted es un rata. Debe cargar mas de 15 sopes sino nos fundimos. Disculpe las Molestias ", "Error!! No sea Rata cargue mas de 15 sopes!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        StringBuilder busqCid = new StringBuilder().AppendFormat("select c.CustomerId from TRANSA_SQL.Customer c where c.PhoneNumber={0}", s.Cliente);
                        this.model.CustomerId = Conexion.Instance.ejecutarQuery(busqCid.ToString()).Rows[0][0].ToString();
                        StringBuilder busqueda = new StringBuilder().Append("select * from TRANSA_SQL.PaymentType pt where pt.Name='").Append(this.comboBox1.Text.TrimStart("Tarjeta ".ToCharArray())).Append("'");
                        DataTable table = Conexion.Instance.ejecutarQuery(busqueda.ToString());
                        if (table.Rows.Count > 0)
                        {
                            payTipe = Convert.ToString(table.Rows[0]["PaymentTypeId"]);
                        }
                        if (this.comboBox1.Text == "Tarjeta Debito" || this.comboBox1.Text == "Tarjeta Crédito")
                        {
                            payTipe = this.model.getOrSetTarjeta();
                        }
                        this.model.cargarCreditoOperation(payTipe);
                        MessageBox.Show("Se ha cargado el credito con exito, no dude en gastarlo!", "Operacion Finalizada con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (NoTenesTarjetaUachoExeption ex)
                    {
                        new TargetaForm(this, this.Model, payTipe).Show();


                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.model.Monto = this.textBox1.Text;
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

        private AbmCliente.SeleccionarForm s = new GrouponDesktop.AbmCliente.SeleccionarForm();

        private void selec_Click(object sender, EventArgs e)
        {
            s.ShowDialog();

        }

    }
}
