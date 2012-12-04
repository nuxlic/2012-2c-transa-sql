using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.Login
{
    public partial class RegristrarProveedor : Form
    {
        private RegistrarProveedorApp model;
        public RegristrarProveedor(int userId)
        {
            InitializeComponent();
            model = new RegistrarProveedorApp(userId);
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            this.model.Ciudad = this.City.Text;
            this.model.CodigoPostal = this.postalCode.Text;
            this.model.Cuit = this.Cuit.Text;
            this.model.Direccion = this.address.Text;
            this.model.RazonSocial = this.corporateName.Text;
            this.model.Mail = this.Mail.Text;
            this.model.NumeroContac = this.ContactNumber.Text;
            this.model.Rubro = this.entry.Text;
            this.model.Telefono = this.Phone.Text;

            if (this.model.registrarProveedor())
            {
                MessageBox.Show(this, "El Proveedor ha sido registrado con Exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.City.Text = "";
            this.postalCode.Text = "";
            this.Cuit.Text = "";
            this.address.Text = "";
            this.corporateName.Text = "";
            this.Mail.Text = "";
            this.ContactNumber.Text = "";
            this.entry.Text = "";
            this.Phone.Text = "";
        }

        private void corporateName_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetras(e);
        }

        private void Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarMail(e);
        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloNumeros(e);
        }

        private void address_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetrasYnumeros(e);
        }

        private void postalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetrasYnumeros(e);
        }

        private void Cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarCuit(e);
        }

        private void entry_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetras(e);
        }

        private void ContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.model.validarSoloLetrasYnumeros(e);
        }
    }
}
