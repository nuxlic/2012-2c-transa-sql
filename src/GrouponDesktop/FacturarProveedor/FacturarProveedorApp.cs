using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlTypes;
using GrouponDesktop.Commons.Database;
using System.Windows.Forms;

namespace GrouponDesktop.FacturarProveedor
{
    public class FacturarProveedorApp
    {
        private string _proveedor;

        public string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }
        private SqlDateTime _fecha1;

        public SqlDateTime Fecha1
        {
            get { return _fecha1; }
            set { _fecha1 = value; }
        }
        private SqlDateTime _fecha2;

        public SqlDateTime Fecha2
        {
            get { return _fecha2; }
            set { _fecha2 = value; }
        }

        public DataTable buscar()
        {
            if (this.Proveedor == null || this.Proveedor == "")
            {
                MessageBox.Show("Debe seleccionar un proveedor a facturar");
                return null;
            }
            else
            {
                Conexion cnn = Conexion.Instance;

                System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

                comando1.CommandType = CommandType.StoredProcedure;
                int contador = 0;

                comando1.Parameters.Add("@proveedor", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.Proveedor;
                contador++;


                comando1.Parameters.Add("@fecha1", SqlDbType.DateTime);
                comando1.Parameters[contador].Value = this.Fecha1;
                contador++;

                comando1.Parameters.Add("@fecha2", SqlDbType.DateTime);
                comando1.Parameters[contador].Value = this.Fecha2;
                contador++;

                comando1.CommandText = "TRANSA_SQL.buscarCuponesAfacturar";

                return cnn.ejecutarQueryConSP(comando1);
            }
        }
    }
}
