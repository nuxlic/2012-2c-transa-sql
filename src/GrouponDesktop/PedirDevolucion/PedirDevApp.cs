using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using GrouponDesktop.Commons.Database;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace GrouponDesktop.PedirDevolucion
{
   public class PedirDevApp
    {
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private string _couponCode;

        public string CouponCode
        {
            get { return _couponCode; }
            set { _couponCode = value; }
        }
        private SqlDateTime _fecha;

        public SqlDateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public void devolver(string razon)
        {
            Conexion cnn = Conexion.Instance;

            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

            comando1.CommandType = CommandType.StoredProcedure;
            int contador = 0;

            comando1.Parameters.Add("@cliente", SqlDbType.Decimal);
            comando1.Parameters[contador].Precision = 18;
            comando1.Parameters[contador].Scale = 0;
            comando1.Parameters[contador].Value = this.Phone;
            contador++;


            comando1.Parameters.Add("@fecha", SqlDbType.DateTime);
            comando1.Parameters[contador].Value = this.Fecha;
            contador++;

            comando1.Parameters.Add("@code", SqlDbType.NVarChar);
            comando1.Parameters[contador].Value = this.CouponCode;
            contador++;

            comando1.Parameters.Add("@reason", SqlDbType.NVarChar);
            comando1.Parameters[contador].Value = razon;
            contador++;

            comando1.CommandText = "TRANSA_SQL.devolverCupon";



            cnn.ejecutarQueryConSP(comando1);
            MessageBox.Show("Ha sido devuelto con exito");

        }

        public DataRow bindear()
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("select c.CustomerId from TRANSA_SQL.Customer c where c.PhoneNumber={0}", this.Phone);
            DataTable tabla=Conexion.Instance.ejecutarQuery(sentence.ToString());
            sentence = new StringBuilder().AppendFormat("select * from TRANSA_SQL.Purchase p where p.CustomerId={0} and p.CouponCode='{1}'", tabla.Rows[0]["CustomerId"].ToString(), this.CouponCode);
            DataTable tabla2 = Conexion.Instance.ejecutarQuery(sentence.ToString());
            if (tabla2.Rows.Count == 0)
            {
                MessageBox.Show("Este cupon no es suyo");
                return null;
            }
            else
            {
                sentence = new StringBuilder().AppendFormat("select top 1 p.CouponBookId from TRANSA_SQL.Purchase p where p.CouponCode='{0}'", this.CouponCode);
                tabla = Conexion.Instance.ejecutarQuery(sentence.ToString());
                sentence = new StringBuilder().AppendFormat("select * from TRANSA_SQL.CouponBook cb where cb.CouponBookId={0}", tabla.Rows[0]["CouponBookId"].ToString());
                return Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows[0];
            }
        }

    }
}
