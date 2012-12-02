using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using GrouponDesktop.Commons.Database;
using System.Data.SqlTypes;
using System.Configuration;
using System.Windows.Forms;

namespace GrouponDesktop.ComprarGiftCard
{
    public class ComprarGiftApp
    {
        private string _clienteOrig;

        public string ClienteOrig
        {
            get { return _clienteOrig; }
            set { _clienteOrig = value; }
        }
        private string _clienteDest;

        public string ClienteDest
        {
            get { return _clienteDest; }
            set { _clienteDest = value; }
        }
        private string _monto;

        public string Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        private ComprarGiftForm _owner;

        public ComprarGiftForm Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public void comprar()
        {
            if (this.ClienteDest == this.ClienteOrig)
            {
                MessageBox.Show("No puede regalarse una giftcard a si mismo");
            }
            else
            {
                Conexion cnn = Conexion.Instance;

                System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

                comando1.CommandType = CommandType.StoredProcedure;

                comando1.Parameters.Add("@orig", SqlDbType.Decimal);
                comando1.Parameters[0].Precision = 18;
                comando1.Parameters[0].Scale = 0;
                comando1.Parameters[0].Value = this.ClienteOrig;

                comando1.Parameters.Add("@dest", SqlDbType.Decimal);
                comando1.Parameters[1].Precision = 18;
                comando1.Parameters[1].Scale = 0;
                comando1.Parameters[1].Value = this.ClienteDest;

                comando1.Parameters.Add("@monto", SqlDbType.Decimal);
                comando1.Parameters[2].Precision = 18;
                comando1.Parameters[2].Scale = 2;
                comando1.Parameters[2].Value = this.Monto;

                int dia = Convert.ToInt32(ConfigurationManager.AppSettings.Get(0));
                int mes = Convert.ToInt32(ConfigurationManager.AppSettings.Get(1));
                int anio = Convert.ToInt32(ConfigurationManager.AppSettings.Get(2));
                SqlDateTime date = new SqlDateTime(anio, mes, dia);
                comando1.Parameters.Add("@fecha", SqlDbType.DateTime);
                comando1.Parameters[3].Value = date;

                comando1.CommandText = "TRANSA_SQL.comprarGiftCard";


                cnn.ejecutarQueryConSP(comando1);

                MessageBox.Show("La gift ha sido cargada con exito");
                this.Owner.Close();
            }
        }
    }
}
