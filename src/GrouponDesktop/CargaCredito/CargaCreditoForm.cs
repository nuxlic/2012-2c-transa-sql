using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.CargaCredito
{
    public partial class CargaCreditoForm : Form
    {
        private DataRow _Usuario;
        private CargaCreditoApplication model;
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
            this.model = new CargaCreditoApplication(Usuario);            
        }

        private void FormaPagoComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.model.TipoPago = this.FormaPagoComBox.Text;
        }

        private void MontoACargarTxtBox_TextChanged(object sender, EventArgs e)
        {
            this.model.Monto=this.MontoACargarTxtBox.Text;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            this.model.cargarCreditoOperation();
            this.Owner.Show();
            this.Close();
        }
    }
}
