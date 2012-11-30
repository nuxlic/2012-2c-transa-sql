using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using GrouponDesktop.Commons.Database;
using System.Data;

namespace GrouponDesktop.AbmProveedor
{
    class ElimProvApp
    {
        public ElimProvApp(DataGridViewRow row)
        {
            this.currentRow = row;
        }

        private DataGridViewRow currentRow;

        public void darDeBaja()
        {
            StringBuilder sentence1 = new StringBuilder().Append("select TRANSA_SQL.CuponeteUser.Deleted from TRANSA_SQL.CuponeteUser where TRANSA_SQL.CuponeteUser.Username='").Append(this.currentRow.Cells["Cuit"].Value).Append("'");
            DataTable table=Conexion.Instance.ejecutarQuery(sentence1.ToString());
            if ((bool)table.Rows[0]["Deleted"])
            {
                MessageBox.Show("El proveedor ya se encontraba dado de baja");
            }
            else
            {
                StringBuilder sentence = new StringBuilder().Append("update TRANSA_SQL.CuponeteUser set Deleted=1 where TRANSA_SQL.CuponeteUser.Username='").Append(this.currentRow.Cells["Cuit"].Value).Append("'");
                Conexion.Instance.ejecutarQuery(sentence.ToString());
                MessageBox.Show("El proveedor ha sido dado de baja con exito");
            }
        }
    }
}
