using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.AbmRol
{
    class ElimRole
    {
        public void eliminar(int roleId)
        {
            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
            comando1.CommandType = CommandType.StoredProcedure;

            comando1.Parameters.Add("@RoleId", SqlDbType.Int);
            comando1.Parameters[0].Value = roleId;

            comando1.CommandText = "TRANSA_SQL.eliminarRole";
            Conexion.Instance.ejecutarQueryConSP(comando1);
        }
    }
}
