using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlTypes;
using GrouponDesktop.Commons.Database;
using System.Configuration;

namespace GrouponDesktop.ArmarCupon
{
    public partial class ArmarCuponForm : Form
    {
        public ArmarCuponForm(DataRow row)
        {
            InitializeComponent();
            this.userRow = row;
        }

        private DataRow userRow;
        private ArmarCuponApp _model = new ArmarCuponApp();

        public ArmarCuponApp Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ArmarCuponForm_Load(object sender, EventArgs e)
        {
            if ((int)this.userRow["RoleId"] == 1)
            {
                StringBuilder sentence = new StringBuilder();
                sentence.Append("select s.Cuit from TRANSA_SQL.Supplier s");
                DataTable proveedores = Conexion.Instance.ejecutarQuery(sentence.ToString());
                for (int i = 0; i < proveedores.Rows.Count; i++)
                {
                    this.comboBox1.Items.Add(proveedores.Rows[i]["Cuit"].ToString());
                }
                this.Model.Proveedor = this.comboBox1.Text;
            }
            else
            {
                this.label11.Hide();
                this.comboBox1.Hide();
                StringBuilder sent = new StringBuilder().AppendFormat("select * from TRANSA_SQL.Supllier s where s.UserId={0}", this.userRow["UserId"].ToString());
                this.Model.Proveedor = Conexion.Instance.ejecutarQuery(sent.ToString()).Rows[0]["Cuit"].ToString();
            }

            StringBuilder sentence2 = new StringBuilder();
            sentence2.Append("SELECT * FROM TRANSA_SQL.City");
            DataTable table = Conexion.Instance.ejecutarQuery(sentence2.ToString());


            for (int i = 0; i < table.Rows.Count; i++)
            {
                this.zonas.Items.Add(table.Rows[i]["Name"].ToString());
            }

            int dia=Convert.ToInt32(ConfigurationManager.AppSettings.Get(0));
            int mes=Convert.ToInt32(ConfigurationManager.AppSettings.Get(1));
            int anio=Convert.ToInt32(ConfigurationManager.AppSettings.Get(2));
            SqlDateTime date = new SqlDateTime(anio, mes, dia);
            this.fecpub.MinDate=date.Value;
            this.fecpub.Value = date.Value;
            this.fecvenccons.MinDate = date.Value;
            this.fecvenccons.Value = date.Value;
            this.fecvencof.MinDate = date.Value;
            this.fecvencof.Value = date.Value;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            //bindeos
            this.Model.Descripcion = this.desc.Text;
            this.Model.CantMax = this.maxallow.Text;
            this.Model.FechaPub = this.fecpub.Value;
            this.Model.FechaVencCons = this.fecvenccons.Value;
            this.Model.FechaVencOfer = this.fecvencof.Value;
            this.Model.PFict = this.pFic.Text;
            this.Model.PReal = this.pReal.Text;
            this.Model.Stock = this.stock.Text;
            List<string> citys = new List<string>();
            foreach (string item in this.zonas.CheckedItems)
            {
                citys.Add(item.Trim());
            }
            this.Model.Zonas = citys;
            this.Model.armar();
            this.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Model.Proveedor = this.comboBox1.Text;
        }
    }
}
