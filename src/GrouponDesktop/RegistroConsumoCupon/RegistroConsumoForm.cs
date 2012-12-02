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

        public RegistrarConsumoApp Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private void RegistroConsumoForm_Load(object sender, EventArgs e)
        {
            if ((int)this.userRow["RoleId"] == 1)
            {
                StringBuilder sentence = new StringBuilder();
                sentence.Append("select s.Cuit from TRANSA_SQL.Supplier s");
                DataTable proveedores = Conexion.Instance.ejecutarQuery(sentence.ToString());
                for (int i = 0; i < proveedores.Rows.Count; i++)
                {
                    this.prov.Items.Add(proveedores.Rows[i]["Cuit"].ToString());
                }
                this.Model.Proveedor = this.prov.Text;
            }
            else
            {
                this.label2.Hide();
                this.prov.Hide();
                StringBuilder sent = new StringBuilder().AppendFormat("select * from TRANSA_SQL.Supplier s where s.UserId={0}", this.userRow["UserId"].ToString());
                this.Model.Proveedor = Conexion.Instance.ejecutarQuery(sent.ToString()).Rows[0]["Cuit"].ToString();
            
                
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            this.Model.Codigo = this.code.Text;
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

        private void prov_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Model.Proveedor = this.prov.Text;
        }
    }
}
