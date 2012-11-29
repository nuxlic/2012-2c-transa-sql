using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GrouponDesktop.Commons.Database;
using System.Data;

using System.Data.SqlTypes;
using System.Windows.Forms;

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

        private DataGridViewRow _couponRow;

        public DataGridViewRow CouponRow
        {
            get { return _couponRow; }
            set { _couponRow = value; }
        }

        public DataTable cargarCupones()
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


                comando1.CommandText = "TRANSA_SQL.buscarCupones";



            return cnn.ejecutarQueryConSP(comando1);
        }

        public void comprar(int cantidad)
        {

            Conexion cnn = Conexion.Instance;

            StringBuilder sentence = new StringBuilder().Append("select c.Amount from TRANSA_SQL.Customer c where c.PhoneNumber=").Append(this.Phone);
            DataTable tab = cnn.ejecutarQuery(sentence.ToString());
            if (Convert.ToDecimal(tab.Rows[0]["Amount"]) < Convert.ToDecimal(this.CouponRow.Cells[5].Value))
            {
                MessageBox.Show("Usted no posee credito para esta compra, por favor haga una recarga");

            }
            else
            {

                System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

                comando1.CommandType = CommandType.StoredProcedure;
                int contador = 0;

                comando1.Parameters.Add("@cliente", SqlDbType.Decimal);
                comando1.Parameters[contador].Precision = 18;
                comando1.Parameters[contador].Scale = 0;
                comando1.Parameters[contador].Value = this.Phone;
                contador++;

                comando1.Parameters.Add("@couponId", SqlDbType.Int);
                comando1.Parameters[contador].Value = this.CouponRow.Cells[1].Value;
                contador++;

                comando1.Parameters.Add("@cantidad", SqlDbType.Int);
                comando1.Parameters[contador].Value = cantidad;
                contador++;


                comando1.Parameters.Add("@fecha", SqlDbType.DateTime);
                comando1.Parameters[contador].Value = this.Fecha;


                comando1.CommandText = "TRANSA_SQL.teLoCompro";



                cnn.ejecutarQueryConSP(comando1);

                MessageBox.Show("Se ha comprado");
            }
        }
    }
}
