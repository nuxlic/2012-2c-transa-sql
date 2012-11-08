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
        private TarjetaDeDebito tarDeb;
        private TarjetaDeCredito tarCred;
        private String _Usuario;

        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }


        public CargaCreditoForm(String user)
        {
            InitializeComponent();
            this.Usuario = user;
        }

        private void CargaCreditoForm_Load(object sender, EventArgs e)
        {
            tarDeb = new TarjetaDeDebito(this.Usuario);
            tarCred = new TarjetaDeCredito(this.Usuario);
            
            this.FormaPagoComBox.Items.Add("Efectivo");
            this.FormaPagoComBox.Items.Add(tarDeb);
            this.FormaPagoComBox.Items.Add(tarCred);
        }
    }
}
