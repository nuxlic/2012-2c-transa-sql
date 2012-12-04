using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.AbmRol
{
    class BusquedaApp
    {
        public string Name { get; set; }
        public DataTable buscar()
        {
            DataTable tabla = new DataTable();

            Conexion cnn = Conexion.Instance;
            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
            comando1.CommandType = CommandType.StoredProcedure;

            if (this.Name != "")
            {
                comando1.Parameters.Add("@Name", SqlDbType.NVarChar);
                comando1.Parameters[0].Value = this.Name;
            }
            comando1.CommandText = "TRANSA_SQL.filtrarRole";
            tabla = cnn.ejecutarQueryConSP(comando1);

            return tabla;
        }
    }
}
