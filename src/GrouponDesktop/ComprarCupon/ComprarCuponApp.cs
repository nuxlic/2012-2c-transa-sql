using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GrouponDesktop.Commons.Database;
using System.Data;

using System.Data.SqlTypes;

namespace GrouponDesktop.ComprarCupon
{
    public class ComprarCuponApp
    {
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private SqlDateTime _fecha;

        public SqlDateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public DataTable cargarCupones()
        {
            Conexion cnn = Conexion.Instance;

            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

            comando1.CommandType = CommandType.StoredProcedure;
            int contador = 0;
            if (this.Phone != "admin")
            {
                comando1.Parameters.Add("@cliente", SqlDbType.Decimal);
                comando1.Parameters[contador].Precision = 18;
                comando1.Parameters[contador].Scale = 0;
                comando1.Parameters[contador].Value = this.Phone;
                contador++;
            }
            
                comando1.Parameters.Add("@fecha", SqlDbType.DateTime);
                comando1.Parameters[contador].Value = this.Fecha;


                comando1.CommandText = "TRANSA_SQL.buscarCupones";



            return cnn.ejecutarQueryConSP(comando1);
        }
    }
}
