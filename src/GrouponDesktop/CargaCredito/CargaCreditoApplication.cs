using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Numeric;
using System.Configuration;
using GrouponDesktop.Commons.Database;
using System.Data.SqlTypes;
using GrouponDesktop.Exeptions;

namespace GrouponDesktop.CargaCredito
{
    class CargaCreditoApplication
    {

        private String _tipoPago;
        private string _Monto;
        private Conexion cnn = Conexion.Instance;
        private string userId;
        private SqlDateTime date;
        private DataTable customer;

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

       
       
        private string _customerId;

        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public CargaCreditoApplication(DataRow user)
        {
            if (user != null)
            {
                this.userRow = user;
                userId = Convert.ToString(this.userRow["UserId"]);
                StringBuilder sentence=new StringBuilder().Append("select * from TRANSA_SQL.Customer cli where cli.UserId=").Append(userId);
                customer = cnn.ejecutarQuery(sentence.ToString());
                _customerId=Convert.ToString(customer.Rows[0]["CustomerId"]);
            }
            int dia=Convert.ToInt32(ConfigurationManager.AppSettings.Get(0));
            int mes=Convert.ToInt32(ConfigurationManager.AppSettings.Get(1));
            int anio=Convert.ToInt32(ConfigurationManager.AppSettings.Get(2));
            date = new SqlDateTime(anio, mes, dia);
            
            
            
        }


        public void cargarCreditoOperation(string payType)
        {
            StringBuilder insert = null;
            if(payType==null)
            {
                insert = new StringBuilder().Append("insert into TRANSA_SQL.CreditLoad values (").Append(_customerId).Append(", '").Append(date.ToString()).Append("', ").Append("null, ").Append(Monto).Append(")");
            }else{
                insert= new StringBuilder().Append("insert into TRANSA_SQL.CreditLoad values (").Append(_customerId).Append(", '").Append(date.ToString()).Append("', ").Append(payType).Append(", ").Append(Monto).Append(")");
            }
            cnn.ejecutarQuery(insert.ToString());
        }

        public string getOrSetTarjeta()
        {
            StringBuilder busqueda = new StringBuilder().Append("select * from TRANSA_SQL.Card c join TRANSA_SQL.CardType ct on c.CardTypeId=ct.CardTypeId join TRANSA_SQL.PaymentType pt on pt.Name=ct.Name where c.CustomerId=").Append(_customerId).Append(" and ct.Name='").Append(TipoPago.TrimStart("Tarjeta ".ToCharArray())).Append("'");
            DataTable table = cnn.ejecutarQuery(busqueda.ToString());
            if (table.Rows.Count == 0)
            {
                throw new NoTenesTarjetaUachoExeption();
            }
            else
            {
                return table.Rows[0]["PaymentTypeId"].ToString();
            }
        }




    }
}
