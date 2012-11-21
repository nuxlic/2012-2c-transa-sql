using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.AbmProveedor;
using GrouponDesktop.CargaCredito;

namespace GrouponDesktop
{
    public partial class MainForm : Form
    {
        

        public MainForm(LoginForm owner, string tipo)
        {   
            InitializeComponent();
            this.tipoUsuario = tipo;
            this._Owner = owner;
            
        }
        private LoginForm _owner;
       
        private String tipoUsuario;
        public LoginForm _Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tipoUsuario == "Administrator")
            {
                cargarCredSobreClientecs f = new cargarCredSobreClientecs();
                f.Show();
            }
            else
            {
                this.Hide();
                CargaCreditoForm f = new CargaCreditoForm(this._owner.Model1.UserRow);
                f.Owner = this;
                f.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //SOLO TEST-- IMPLEMENTAR QUE TOME LOS PERMISOS DESDE LA BASE
            
            if (tipoUsuario == "Customer")
            {
                this.abms.Hide();
                this.facturar.Hide();
                this.estadistica.Hide();
                this.Armar_Cupon.Hide();
                this.registrarConsumo.Hide();
                this.Publicar_Cupon.Hide();
            }
            else if (tipoUsuario == "Supplier")
            {
                this.abms.Hide();
                this.facturar.Hide();
                this.estadistica.Hide();
                this.comprar_cupon.Hide();
                this.Comprar_GiftCard.Hide();
                this.cargarCred.Hide();
                this.Devolver_cupon.Hide();
                this.historial.Hide();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void abms_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProveedorForm prov= new ProveedorForm();
            prov.Owner = this;
            prov.Show();
        }
    }
}
