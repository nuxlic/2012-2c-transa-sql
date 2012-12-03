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

        private List<int> _publicables = new List<int>();

        public List<int> Publicables
        {
            get { return _publicables; }
            set { _publicables = value; }
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

        public void publicar()
        {
            System.Data.SqlClient.SqlCommand comando2 = new System.Data.SqlClient.SqlCommand();

            comando2.CommandType = CommandType.StoredProcedure;
            

            comando2.Parameters.Add("@fecha", SqlDbType.DateTime);
            comando2.Parameters[0].Value = this.Fecha;
            comando2.Parameters.Add("@CouponBookId", SqlDbType.Int);
            comando2.CommandText = "TRANSA_SQL.publicar";
            foreach (int id in this.Publicables)
            {
                comando2.Parameters[1].Value =  id;
                Conexion.Instance.ejecutarQueryConSP(comando2);
            }

           
        }
    }
}
