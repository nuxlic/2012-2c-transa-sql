using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.RegistroConsumoCupon
{
    public partial class RegistroConsumoForm : Form
    {
        public RegistroConsumoForm(DataRow row)
        {
            InitializeComponent();
            this.Model = new RegistrarConsumoApp(this);
            this.userRow = row;
        }

        private DataRow userRow;
        private RegistrarConsumoApp _model;
        private AbmProveedor.SeleccionarForm s = new GrouponDesktop.AbmProveedor.SeleccionarForm();
        public RegistrarConsumoApp Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private void RegistroConsumoForm_Load(object sender, EventArgs e)
        {
            if ((int)this.userRow["RoleId"] != 1)
            {
                this.label2.Hide();
                this.button1.Hide();
                StringBuilder sent = new StringBuilder().AppendFormat("select * from TRANSA_SQL.Supplier s where s.UserId={0}", this.userRow["UserId"].ToString());
                this.Model.Proveedor = Conexion.Instance.ejecutarQuery(sent.ToString()).Rows[0]["Cuit"].ToString();

            }
            else
            {
                this.Model.Proveedor = s.Prov;
            }
            
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            this.Model.Codigo = this.code.Text;
            if ((int)this.userRow["RoleId"] != 1)
            {
                
                StringBuilder sent = new StringBuilder().AppendFormat("select * from TRANSA_SQL.Supplier s where s.UserId={0}", this.userRow["UserId"].ToString());
                this.Model.Proveedor = Conexion.Instance.ejecutarQuery(sent.ToString()).Rows[0]["Cuit"].ToString();

            }
            else
            {
                this.Model.Proveedor = s.Prov;
            }
            this.Model.registrar();
        }

        private void prov_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void code_KeyPress(object sender, KeyPressEventArgs e)
        {
            new AbmProveedor.AltaProvApp().validarSoloLetrasYnumeros(e);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {   
            
            s.Show();
            
            
        }
    }
}
