using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlTypes;
using System.Data;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.PublicarCupon
{
    public class PublicarCuponApp
    {
        private string _proveedor;

        public string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }
        private SqlDateTime _fecha;

        public SqlDateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public DataTable buscar()
        {
            Conexion cnn = Conexion.Instance;

            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

            comando1.CommandType = CommandType.StoredProcedure;
            int contador = 0;

            comando1.Parameters.Add("@proveedor", SqlDbType.NVarChar);
            comando1.Parameters[contador].Value = this.Proveedor;
            contador++;


            comando1.Parameters.Add("@fecha", SqlDbType.DateTime);
            comando1.Parameters[contador].Value = this.Fecha;


            comando1.CommandText = "TRANSA_SQL.buscarCuponesApublicar";

            return cnn.ejecutarQueryConSP(comando1);
        }
    }
}
