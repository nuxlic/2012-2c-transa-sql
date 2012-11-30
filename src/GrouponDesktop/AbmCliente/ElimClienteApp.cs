using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Commons.Database;
using System.Windows.Forms;
using System.Data;

namespace GrouponDesktop.AbmCliente
{
    class ElimClienteApp
    {
        public ElimClienteApp(DataGridViewRow row)
        {
            this.currentRow = row;
        }

        private DataGridViewRow currentRow;

        public void darDeBaja()
        {
            Conexion conn = Conexion.Instance;
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT C.UserId FROM TRANSA_SQL.Customer C WHERE C.PhoneNumber={0}", currentRow.Cells["PhoneNumber"].Value.ToString());
            int userId = (int)conn.ejecutarQuery(sentence.ToString()).Rows[0][0];

            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
            comando1.CommandType = CommandType.StoredProcedure;

            comando1.Parameters.Add("@UserId", SqlDbType.Int);
            comando1.Parameters[0].Value = userId;

            comando1.CommandText = "TRANSA_SQL.eliminarCliente";
            conn.ejecutarQueryConSP(comando1);

            MessageBox.Show("El cliente ha sido dado de baja con exito");
        }
    }
}
