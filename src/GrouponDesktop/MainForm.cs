﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.AbmProveedor;
using GrouponDesktop.CargaCredito;
using GrouponDesktop.PublicarCupon;
using GrouponDesktop.AbmRol;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop
{
    public partial class MainForm : Form
    {
        MainFormApplication Model = new MainFormApplication();
        private string Username;
        private string Password;

        public MainForm(string username, string password)
        {   
            InitializeComponent();
            this.Username = username;
            this.Password = password;
        }
        private LoginForm _owner;

        private String tipoUsuario;

        public String TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }
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
            if (this.tipoUsuario != "Administrator")
            {
                this.btnOpciones.Visible = true;
            }
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT CU.RoleId FROM TRANSA_SQL.CuponeteUser CU WHERE CU.Username='{0}'", this.Username);
            int roleId = (int)Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows[0]["RoleId"];
            List<int>permisos = this.Model.GetPermission(roleId);
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
            if (permisos.Any(unPermiso => unPermiso == 20))
            {
                this.btnChangeRole.Visible = true;
            }
            

            if (permisos.Any(unPermiso => unPermiso == 1 || unPermiso == 2 || unPermiso == 3 || unPermiso == 4 || unPermiso == 5 || unPermiso == 6 || unPermiso == 7 || unPermiso == 8 || unPermiso == 9))
            {
                this.abms.Visible = true;
            }
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose(true);
        }

        private void abms_Click_1(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT CU.RoleId FROM TRANSA_SQL.CuponeteUser CU WHERE CU.Username='{0}'", this.Username);
            int roleId = (int)Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows[0]["RoleId"];

            this.Hide();
            AbmMain abms= new AbmMain(roleId);
            abms.Owner = this;
            abms.Show();
        }

        private void Comprar_GiftCard_Click(object sender, EventArgs e)
        {
            ComprarGiftCard.ComprarGiftForm c= new ComprarGiftCard.ComprarGiftForm(this._Owner.Model1.UserRow);
            c.Owner = this;
            //this.Hide();
            c.Show();
        }

        private void comprar_cupon_Click(object sender, EventArgs e)
        {
            ComprarCupon.ComprarCuponForm cc = new ComprarCupon.ComprarCuponForm(this._Owner.Model1.UserRow);
            cc.Owner = this;
            //this.Hide();
            cc.Show();
        }

        private void historial_Click(object sender, EventArgs e)
        {
            HistorialCupones.HistorialCuponesForm h = new HistorialCupones.HistorialCuponesForm(this._Owner.Model1.UserRow);
            h.Owner = this;
            h.Show();
        }

        private void Devolver_cupon_Click(object sender, EventArgs e)
        {
            PedirDevolucion.PedirDevolucionForm p = new PedirDevolucion.PedirDevolucionForm(this._owner.Model1.UserRow);
            p.Owner = this;
            //this.Hide();
            p.Show();
        }

        private void Armar_Cupon_Click(object sender, EventArgs e)
        {
            ArmarCupon.ArmarCuponForm ac = new ArmarCupon.ArmarCuponForm(this._owner.Model1.UserRow);
            ac.Owner = this;
            ac.Show();
        }

        private void registrarConsumo_Click(object sender, EventArgs e)
        {
            RegistroConsumoCupon.RegistroConsumoForm rc = new RegistroConsumoCupon.RegistroConsumoForm(this._owner.Model1.UserRow);
            rc.Owner = this;
            rc.Show();
        }

        private void Publicar_Cupon_Click(object sender, EventArgs e)
        {
            PublicarCuponForm pc = new PublicarCuponForm();
            pc.Owner = this;
            pc.Show();              
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            OpcionesUsuarioForm opciones = new OpcionesUsuarioForm(this.Username, this.Password);
            opciones.ShowDialog();
            if (opciones.Bajado)
            {
                _owner.Show();
                this.Close();
            }
        }

        private void facturar_Click(object sender, EventArgs e)
        {
            FacturarProveedor.FacturarProveedorForm fp = new FacturarProveedor.FacturarProveedorForm();
            fp.Owner = this;
            fp.Show();
        }

        private void estadistica_Click(object sender, EventArgs e)
        {
            ListadoEstadistico.ListadoMainForm l = new GrouponDesktop.ListadoEstadistico.ListadoMainForm();
            l.Owner = this;
            l.Show();
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            BusqUsuarioCambiarRoleForm busqModifUserRole = new BusqUsuarioCambiarRoleForm();
            this.Hide();
            busqModifUserRole.ShowDialog();
            this.Show();
        }
    }
}
