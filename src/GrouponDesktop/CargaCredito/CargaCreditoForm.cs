using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.Exeptions;

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
            if (Convert.ToInt32(this.MontoACargarTxtBox.Text) < 15)
            {
                MessageBox.Show("Error CN23: Usted es un rata. Debe cargar mas de 15 sopes sino nos fundimos. Disculpe las Molestias ", "Error!! No sea Rata cargue mas de 15 sopes!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (this.FormaPagoComBox.Text == "Tarjeta Debito" || this.FormaPagoComBox.Text == "Tarjeta Credito")
                    {
                        this.Model.getOrSetTarjeta();
                    }
                    this.Model.cargarCreditoOperation();
                    MessageBox.Show("Se ha cargado el credito con exito, no dude en gastarlo!", "Operacion Finalizada con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Owner.Show();
                    this.Close();
                }
                catch (NoTenesTarjetaUachoExeption ex)
                {
                    new TargetaForm(this).Show();
                    this.Hide();
                    //this.Owner.Show();
                }
            }
        }
    }
}
