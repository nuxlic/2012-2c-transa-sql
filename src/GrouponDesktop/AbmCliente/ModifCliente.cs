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

        public int Dni { get; set; }
        private ModifClienteApp model;

        public ModifCliente(int dni)
        {
            InitializeComponent();

            this.Dni = dni;

            Conexion conn = Conexion.Instance;
            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

            //Se usa el DNI porque es Unique.
            comando1.Parameters.Add("@dni", SqlDbType.Int);
            comando1.Parameters[0].Value = this.Dni;
            comando1.CommandText = "TRANSA_SQL.filtrarCliente";
            DataTable table = conn.ejecutarQueryConSP(comando1);

            this.model = new ModifClienteApp(table.Rows[0]);
            List<string> citys = this.model.getCitys();
            List<string> checkedCitys = this.model.getCheckedCitys(dni);
            

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
    }
}
