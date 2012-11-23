using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Commons.Database;
using System.Data;

namespace GrouponDesktop
{
    class MainFormApplication
    {
        Conexion connSqlClient= Conexion.Instance;

        public List<int> GetPermission(string tipoUsuario)
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT * FROM TRANSA_SQL.Permission P JOIN TRANSA_SQL.RolePermission RP ON RP.PermissionId=P.PermissionId JOIN TRANSA_SQL.Role R ON R.RoleId=RP.RoleId WHERE R.Name='{0}'", tipoUsuario);
            DataTable tabla = connSqlClient.ejecutarQuery(sentence.ToString());
            List<int> ret = new List<int>();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                ret.Add((int)tabla.Rows[i][0]);
            }
            
            return ret;
        }

    }
}
