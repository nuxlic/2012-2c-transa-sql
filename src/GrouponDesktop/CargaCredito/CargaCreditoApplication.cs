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
            this.userRow = user;
            userId=Convert.ToString(this.userRow["UserId"]);
            int dia=Convert.ToInt32(ConfigurationManager.AppSettings.Get(0));
            int mes=Convert.ToInt32(ConfigurationManager.AppSettings.Get(1));
            int anio=Convert.ToInt32(ConfigurationManager.AppSettings.Get(2));
            date = new SqlDateTime(anio, mes, dia);
            
            StringBuilder sentence=new StringBuilder().Append("select * from TRANSA_SQL.Customer cli where cli.UserId=").Append(userId);
            customer = cnn.ejecutarQuery(sentence.ToString());
            _customerId=Convert.ToString(customer.Rows[0]["CustomerId"]);
        }


        public void cargarCreditoOperation()
        {
            StringBuilder insert = new StringBuilder().Append("insert into TRANSA_SQL.CreditLoad values (").Append(_customerId).Append(", ").Append(date.ToString().Substring(0,date.ToString().Length-7)).Append(", null, ").Append(Monto).Append(")");
            cnn.ejecutarQuery(insert.ToString());
        }

        public void getOrSetTarjeta()
        {
            StringBuilder busqueda = new StringBuilder().Append("select * from TRANSA_SQL.Card c join TRANSA_SQL.CardType ct on c.CardTypeId=ct.CardTypeId where c.CustomerId=").Append(_customerId).Append(" and ct.Name='").Append(TipoPago.TrimStart("Tarjeta ".ToCharArray())).Append("'");
            DataTable table = cnn.ejecutarQuery(busqueda.ToString());
            if (table.Rows.Count == 0)
            {
                throw new NoTenesTarjetaUachoExeption();
            }
        }




    }
}
