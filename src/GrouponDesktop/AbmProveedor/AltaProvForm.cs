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
        
        private void AltaProvForm_Load(object sender, EventArgs e)
                {
                    
                }
        
        private void guardar_Click(object sender, EventArgs e)
        {
            //TODO meterle la logica

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

        

        

        
    }
}
