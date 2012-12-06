using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.ListadoEstadistico
{
   public class Top5DevApp : IListadoModel
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

           comando1.CommandText = "TRANSA_SQL.listarTop5Dev";

           DataTable table = cnn.ejecutarQueryConSP(comando1);

           int cont = 0;
           for (int i = 0; i < table.Rows.Count; i++)
           {
               if (float.Parse(table.Rows[i][4].ToString()) == 0.000)
               {
                   cont += 1;
               }
           }
           if (cont != table.Rows.Count) return table;
           else return new DataTable();
       }
    }
}
