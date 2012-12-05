using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Commons.Database;
using System.Data;

namespace GrouponDesktop.AbmCliente
{
    class AltaRolApp
    {
        public void crearRol(string nombre, List<string> permisos)
        {
            StringBuilder getLastRoleId = new StringBuilder().AppendFormat("SELECT R.RoleId FROM TRANSA_SQL.Role R ORDER BY R.RoleId DESC", nombre);
            int roleId = (int)(Conexion.Instance.ejecutarQuery(getLastRoleId.ToString()).Rows[0][0]) + 1;

            StringBuilder sentence1 = new StringBuilder().AppendFormat("INSERT INTO TRANSA_SQL.Role(RoleId, Name, Enabled) VALUES ({0},'{1}',2)",roleId, nombre);
            Conexion.Instance.ejecutarQuery(sentence1.ToString());

            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
            comando1.CommandType = CommandType.StoredProcedure;

            comando1.Parameters.Add("@RoleId", SqlDbType.Int);
            comando1.Parameters.Add("@PermissionId", SqlDbType.Int);

            comando1.Parameters[0].Value = roleId;

            StringBuilder sentence4;
            comando1.CommandText = "TRANSA_SQL.agregarRolePermission";
            
            foreach (string permiso in permisos)
            {
                sentence4 = new StringBuilder().AppendFormat("SELECT P.PermissionId FROM TRANSA_SQL.Permission P WHERE P.Name='{0}'", permiso);
                comando1.Parameters[1].Value = (int)Conexion.Instance.ejecutarQuery(sentence4.ToString()).Rows[0][0];
                Conexion.Instance.ejecutarQueryConSP(comando1);
            }
        }
        public void validarSoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
