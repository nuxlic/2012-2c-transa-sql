using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.AbmProveedor
{
    public partial class AltaProvForm : Form
    {
        public AltaProvForm()
        {
            InitializeComponent();
        }

        private AltaProvApp model = new AltaProvApp();
        
        protected virtual void AltaProvForm_Load(object sender, EventArgs e)
                {
                    
                }
        
        public virtual void guardar_Click(object sender, EventArgs e)
        {
            

            //Bindeos 
            this.model.RazonSocial = this.corporateName.Text;
            this.model.Mail = this.Mail.Text;
            this.model.Telefono = this.Phone.Text;
            this.model.Direccion = this.address.Text;
            this.model.CodigoPostal = this.postalCode.Text;
            this.model.Ciudad = this.City.Text;
            this.model.Cuit = this.Cuit.Text;
            this.model.Rubro = this.entry.Text;
            this.model.NumeroContac = this.ContactNumber.Text;

            this.model.crearSupplier();

            this.Owner.Show();
            this.Close();
        }

        protected virtual void corporateName_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetrasYnumeros(e);
        }

        protected virtual void Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarMail(e);
        }

        protected virtual void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloNumeros(e);
        }

        protected virtual void postalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetrasYnumeros(e);
        }

        protected virtual void City_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetras(e);
        }

        protected virtual void Cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarCuit(e);
        }

        protected virtual void address_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetrasYnumeros(e);
        }

        protected virtual void entry_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetras(e);
        }

        protected virtual void ContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetrasYnumeros(e);
        }

        protected virtual void Limpiar_Click(object sender, EventArgs e)
        {
            this.corporateName.Text = null;
            this.Mail.Text = null;
            this.Phone.Text = null;
            this.address.Text = null;
            this.postalCode.Text = null;
            this.City.Text = null;
            this.Cuit.Text = null;
            this.entry.Text = null;
            this.ContactNumber.Text = null;
        }

        

        

        
    }
}
