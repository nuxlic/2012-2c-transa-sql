using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Numeric;
using System.Configuration;
using GrouponDesktop.Commons.Database;
using System.Data.SqlTypes;

namespace GrouponDesktop.CargaCredito
{
    class CargaCreditoApplication
    {

        private String _tipoPago;
        private string _Monto;

        public string Monto
        {
            get { return _Monto; }
            set { _Monto = value; }
        }

        public String TipoPago
        {
            get { return _tipoPago; }
            set { _tipoPago = value; }
        }
        private DataRow userRow;

        public CargaCreditoApplication(DataRow user)
        {
            this.userRow = user;
            
        }


        public void cargarCreditoOperation()
        {
            //por ahora no anda
            string userId=Convert.ToString(this.userRow["UserId"]);
            int dia=Convert.ToInt32(ConfigurationManager.AppSettings.Get(0));
            int mes=Convert.ToInt32(ConfigurationManager.AppSettings.Get(1));
            int anio=Convert.ToInt32(ConfigurationManager.AppSettings.Get(2));
            SqlDateTime date = new SqlDateTime(anio, mes, dia);
            Conexion cnn = Conexion.Instance;
            StringBuilder sentence=new StringBuilder().Append("select * from TRANSA_SQL.Customer cli where cli.UserId=").Append(userId);
            DataTable table = cnn.ejecutarQuery(sentence.ToString());
            string customerId=Convert.ToString(table.Rows[0]["CustomerId"]);
            StringBuilder insert = new StringBuilder().Append("insert into TRANSA_SQL.CreditLoad values (").Append(customerId).Append(", ").Append(date.ToString().Substring(0,date.ToString().Length-7)).Append(", null, ").Append(Monto).Append(")");
            cnn.ejecutarQuery(insert.ToString());
        }






    }
}
