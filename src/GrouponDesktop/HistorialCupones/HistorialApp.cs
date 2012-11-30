using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.HistorialCupones
{
    public class HistorialApp
    {
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private DateTime _fecha1;

        public DateTime Fecha1
        {
            get { return _fecha1; }
            set { _fecha1 = value; }
        }

        private DateTime _fecha2;

        public DateTime Fecha2
        {
            get { return _fecha2; }
            set { _fecha2 = value; }
        }

        public DataTable mostrarhistorial()
        {
            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

            comando1.CommandType = CommandType.StoredProcedure;
            int contador = 0;

            comando1.Parameters.Add("@cliente", SqlDbType.Decimal);
            comando1.Parameters[contador].Precision = 18;
            comando1.Parameters[contador].Scale = 0;
            comando1.Parameters[contador].Value = this.Phone;
            contador++;

            comando1.Parameters.Add("@fecha1", SqlDbType.DateTime);
            comando1.Parameters[contador].Value = this.Fecha1;
            contador++;

            comando1.Parameters.Add("@fecha2", SqlDbType.DateTime);
            comando1.Parameters[contador].Value = this.Fecha2;
            contador++;

            comando1.CommandText = "TRANSA_SQL.historial";



            return Conexion.Instance.ejecutarQueryConSP(comando1);

        }
    }
}
