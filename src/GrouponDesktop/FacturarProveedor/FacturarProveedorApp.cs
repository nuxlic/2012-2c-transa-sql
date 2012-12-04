using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlTypes;
using GrouponDesktop.Commons.Database;
using System.Windows.Forms;
using System.Configuration;

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

        private Int64 _nroFactura;

        public Int64 NroFactura
        {
            get { return _nroFactura; }
            set { _nroFactura = value; }
        }

        private Int64 _monto;

        public Int64 Monto
        {
            get { return _monto; }
            set { _monto = value; }
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
        public Int64 getNumero()
        {
            StringBuilder sent = new StringBuilder().Append("select b.Number from TRANSA_SQL.Bill b order by 1 desc");
            this.NroFactura = Convert.ToInt64(Conexion.Instance.ejecutarQuery(sent.ToString()).Rows[0][0]) + 1;
            return Convert.ToInt64(Conexion.Instance.ejecutarQuery(sent.ToString()).Rows[0][0]) + 1;
        }

        public Int64 getImporte(DataGridView c)
        {
            Int64 monto = 0;
            for (int j = 0; j < c.Rows.Count; j++)
            {
                monto += Convert.ToInt64(c.Rows[j].Cells["Precio Oferta"].Value);
            }
            this.Monto = monto;
            return monto;
        }

        public void conferccionarFactura()
        {
            Conexion cnn = Conexion.Instance;

            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

            comando1.CommandType = CommandType.StoredProcedure;
            int contador = 0;

            comando1.Parameters.Add("@proveedor", SqlDbType.NVarChar);
            comando1.Parameters[contador].Value = this.Proveedor;
            contador++;


            comando1.Parameters.Add("@fecha", SqlDbType.DateTime);
            int dia = Convert.ToInt32(ConfigurationManager.AppSettings.Get(0));
            int mes = Convert.ToInt32(ConfigurationManager.AppSettings.Get(1));
            int anio = Convert.ToInt32(ConfigurationManager.AppSettings.Get(2));
            comando1.Parameters[contador].Value =new SqlDateTime(anio, mes, dia); ;
            contador++;

            comando1.Parameters.Add("@monto", SqlDbType.Money);
            comando1.Parameters[contador].Value = this.Monto;
            contador++;

            comando1.Parameters.Add("@factura", SqlDbType.Decimal);
            comando1.Parameters[contador].Precision = 18;
            comando1.Parameters[contador].Scale = 0;
            comando1.Parameters[contador].Value = this.NroFactura;
            contador++;
        }


    }
}
