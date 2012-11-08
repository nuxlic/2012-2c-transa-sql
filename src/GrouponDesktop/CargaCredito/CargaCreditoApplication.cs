using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Numeric;
using System.Configuration;
using GrouponDesktop.Commons.Database;

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
            /*string userId=Convert.ToString(this.userRow["UserId"]);
            string fecha=(String)ConfigurationManager.GetSection("Fecha");
            Conexion cnn = Conexion.Instance;
            StringBuilder sentence=new StringBuilder().Append("select * from TRANSA_SQL.Customer cli where cli.UserId=").Append(userId);
            DataTable table = cnn.ejecutarQuery(sentence.ToString());
            string customerId=Convert.ToString(table.Rows[0]["CustomerId"]);
            StringBuilder insert = new StringBuilder().Append("insert into TRANSA_SQL.CreditLoad (").Append(customerId).Append(", ").Append(fecha).Append(", null, ").Append(Monto).Append(")");
            cnn.ejecutarQuery(insert.ToString());
        */}






    }
}
