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

        public List<int> GetPermission(int roleId)
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT * FROM TRANSA_SQL.Permission P JOIN TRANSA_SQL.RolePermission RP ON RP.PermissionId=P.PermissionId WHERE RP.RoleId='{0}'", roleId);
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
