using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.AbmCliente
{
    public partial class ModifCliente : Form
    {
        private ModifClienteApp model;
        public int Dni { get; set; }
        public ModifCliente(DataGridViewRow row)
        {
            InitializeComponent();
            this.Dni = Int32.Parse(row.Cells["Dni"].Value.ToString());
            this.model = new ModifClienteApp(row);
            List<string> citys = this.model.getCitys();
            List<string> checkedCitys = this.model.getCheckedCitys(this.Dni);
            
            //Bindeos...
            this.txtName.Text = this.model.Nombre;
            this.txtSurname.Text = this.model.Apellido;
            this.txtDni.Text = this.model.Dni;
            this.txtEmail.Text = this.model.Mail;
            this.txtPhone.Text = this.model.Phone;
            this.txtAddress.Text = this.model.Address;
            this.txtPostalCode.Text = this.model.PostalCode;
            this.dtpBirhtday.Value = DateTime.Parse(this.model.FechaNac);


            for (int i = 0; i < citys.Count; i++)
            {
                int index = this.chkBoxListPreferences.Items.Add(citys[i]);
                if (checkedCitys.Any(city => city == citys[i]))
                {
                    this.chkBoxListPreferences.SetItemChecked(index, true);
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.model.Nombre = this.txtName.Text;
            this.model.Apellido= this.txtSurname.Text;
            this.model.Dni = this.txtDni.Text;
            this.model.Mail = this.txtEmail.Text;
            this.model.Phone = this.txtPhone.Text;
            this.model.Address = this.txtAddress.Text;
            this.model.PostalCode = this.txtPostalCode.Text;
            this.model.FechaNac = this.dtpBirhtday.Value.ToString();

            this.model.modificar();

            List<string> citys = new List<string>();
            foreach (string item in this.chkBoxListPreferences.CheckedItems)
            {
                citys.Add(item.Trim());
            }

            this.model.setCitys(this.Dni, citys);

            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloLetras(e);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloNumeros(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarMail(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloNumeros(e);
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloLetrasYnumeros(e);
        }

        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            new CreateCustomerApplication().validarSoloLetrasYnumeros(e);
        }

    }
}
