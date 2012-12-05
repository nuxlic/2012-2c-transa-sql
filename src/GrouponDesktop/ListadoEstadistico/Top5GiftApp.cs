using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.ListadoEstadistico
{
    public class Top5GiftApp:IListadoModel
    {
        public DataTable listar(int semestre, int anio)
        {
            Conexion cnn = Conexion.Instance;

            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

            comando1.CommandType = CommandType.StoredProcedure;
            int contador = 0;

            comando1.Parameters.Add("@semestre", SqlDbType.Int);
            comando1.Parameters[contador].Value = semestre;
            contador++;


            comando1.Parameters.Add("@anio", SqlDbType.Int);
            comando1.Parameters[contador].Value = anio;
            contador++;

            comando1.CommandText = "TRANSA_SQL.listarTop5Gift";

            return cnn.ejecutarQueryConSP(comando1);
        }
    }
}
