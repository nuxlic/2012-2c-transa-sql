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
        MainFormApplication Model = new MainFormApplication();
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
                
                CargaCreditoForm f = new CargaCreditoForm(this._owner.Model1.UserRow);
                f.Owner = this;
                f.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TODO: HAY QUE HACER UN ENUM PARA LOS PERMISOS!!!!!!!!! >.<
            //TODO: HAY QUE HACER UN ENUM PARA LOS PERMISOS!!!!!!!!! >.<
            //TODO: HAY QUE HACER UN ENUM PARA LOS PERMISOS!!!!!!!!! >.<
            //TODO: HAY QUE HACER UN ENUM PARA LOS PERMISOS!!!!!!!!! >.<

            //TODO: HAY QUE REGISTRAR LOS PERMISOS DEL ADMINISTRADOR EN LA BASE DE DATOS!
            //TODO: SIMPLEMENTE ES AGREGAR EL ROL Y PONERLE LOS PERMISOS QUE YA ESTAN!

            List<int>permisos = this.Model.GetPermission(this.tipoUsuario);
            if(permisos.Any(unPermiso => unPermiso == 12))
            {
                this.comprar_cupon.Visible=true;
            }
            if(permisos.Any(unPermiso => unPermiso == 11))
            {
                this.Comprar_GiftCard.Visible=true;
            }
            if(permisos.Any(unPermiso => unPermiso == 15))
            {
                this.Armar_Cupon.Visible=true;
            }
            if(permisos.Any(unPermiso => unPermiso == 10))
            {
                this.cargarCred.Visible=true;
            }
            if(permisos.Any(unPermiso => unPermiso == 17))
            {
                this.Publicar_Cupon.Visible=true;
            }
            if(permisos.Any(unPermiso => unPermiso == 16))
            {
                this.registrarConsumo.Visible=true;
            }
            if(permisos.Any(unPermiso => unPermiso == 14))
            {
                this.historial.Visible=true;
            }
            if(permisos.Any(unPermiso => unPermiso == 13))
            {
                this.Devolver_cupon.Visible=true;
            }
            if(permisos.Any(unPermiso => unPermiso == 19))
            {
                this.estadistica.Visible=true;
            }
            if (permisos.Any(unPermiso => unPermiso == 18))
            {
                this.facturar.Visible = true;
            }
            //hay que sacar el boton AMBS y poner todos los botones individualizados
            if (permisos.Any(unPermiso => unPermiso == 1 || unPermiso == 2 || unPermiso == 3 || unPermiso == 4 || unPermiso == 5 || unPermiso == 6 || unPermiso == 7 || unPermiso == 8 || unPermiso == 9))
            {
                this.abms.Visible = true;
            }

        }

        

        

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void abms_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AbmMain abms= new AbmMain(this.tipoUsuario);
            abms.Owner = this;
            abms.Show();
        }
    }
}
