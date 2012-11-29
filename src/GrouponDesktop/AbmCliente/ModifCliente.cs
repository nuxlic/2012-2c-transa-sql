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

        public int CustomerId { get; set; }
        private ModifClienteApp model;

        public ModifCliente(int customerId)
        {
            InitializeComponent();
            this.CustomerId = customerId;
        }

        public ModifCliente()
        {
            InitializeComponent();
        }

        private void ModifCliente_Load(object sender, EventArgs e)
        {
            Conexion conn = Conexion.Instance;
            DataTable table = conn.ejecutarQuery(String.Format("SELECT * FROM TRANSA_SQL.Customer WHERE CustomerId={0}", this.CustomerId));

            this.model = new ModifClienteApp(table.Rows[0]);
            
            List<string> citys = this.model.getCitys();
            List<string> checkedCitys = this.model.getCheckedCitys(this.CustomerId);
            for (int i = 0; i < citys.Count; i++)
            {
                int index = this.chkBoxListPreferences.Items.Add(citys[i]);
                if(checkedCitys.Any(city => city == citys[i]))
                {
                    this.chkBoxListPreferences.SetItemChecked(index, true);
                }
            }
        }
    }
}
