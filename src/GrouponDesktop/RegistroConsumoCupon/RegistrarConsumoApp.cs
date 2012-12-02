using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data.SqlTypes;
using System.Data;
using GrouponDesktop.Commons.Database;
using System.Windows.Forms;

namespace GrouponDesktop.RegistroConsumoCupon
{
    public class RegistrarConsumoApp
    {
        public RegistrarConsumoApp(RegistroConsumoForm own)
        {
            this.Owner = own;
        }

        private string _proveedor;
        private SqlDateTime _fecha;

        public SqlDateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }
        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private RegistroConsumoForm _owner;

        public RegistroConsumoForm Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public void registrar()
        {
            if (this.Codigo == "" || this.Codigo == null || this.Proveedor == "" || this.Proveedor == null)
            {
                MessageBox.Show("Debe completar los campos");
            }
            else
            {       int dia = Convert.ToInt32(ConfigurationManager.AppSettings.Get(0));
                    int mes = Convert.ToInt32(ConfigurationManager.AppSettings.Get(1));
                    int anio = Convert.ToInt32(ConfigurationManager.AppSettings.Get(2));
                    SqlDateTime date = new SqlDateTime(anio, mes, dia);
                    this.Fecha = date;
                if (!this.validar())
                {


                    


                    System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

                    comando1.CommandType = CommandType.StoredProcedure;
                    int contador = 0;

                    comando1.Parameters.Add("@proveedor", SqlDbType.NVarChar);
                    comando1.Parameters[contador].Value = this.Proveedor;
                    contador++;

                    comando1.Parameters.Add("@fecha", SqlDbType.DateTime);
                    comando1.Parameters[contador].Value = this.Fecha;
                    contador++;

                    comando1.Parameters.Add("@couponCode", SqlDbType.NVarChar);
                    comando1.Parameters[contador].Value = this.Codigo;
                    contador++;

                    comando1.CommandText = "TRANSA_SQL.registrarConsumo";
                    Conexion.Instance.ejecutarQueryConSP(comando1);

                    MessageBox.Show("Canje Exitoso!");
                    this.Owner.Close();
                }
            }

            
        }
        public bool validar()
        {
            StringBuilder control1 = new StringBuilder().AppendFormat("select * from TRANSA_SQL.ConsumedCoupon c where c.CouponCode='{0}'", this.Codigo);
            if (Conexion.Instance.ejecutarQuery(control1.ToString()).Rows.Count > 0)
            {
                MessageBox.Show("Este cupon ya ha sido canjeado");
                return true;
            }
            control1 = new StringBuilder().AppendFormat("select * from TRANSA_SQL.CouponBook cb join TRANSA_SQL.Purchase c on c.CouponBookId=cb.CouponBookId join TRANSA_SQL.Supplier s on s.SupplierId=cb.SupplierId where c.CouponCode='{0}' and s.Cuit='{1}'", this.Codigo, this.Proveedor);

            if (Conexion.Instance.ejecutarQuery(control1.ToString()).Rows.Count == 0)
            {
                MessageBox.Show("Este cupon no pertenece a este proveedor");
                return true;
            }
                control1 = new StringBuilder().AppendFormat("select cb.ConsumptionMaturityDate from TRANSA_SQL.CouponBook cb join TRANSA_SQL.Purchase c on c.CouponBookId=cb.CouponBookId where c.CouponCode='{0}'", this.Codigo);
                string venc=Conexion.Instance.ejecutarQuery(control1.ToString()).Rows[0][0].ToString();
                if (venc != null && venc != "")
                {                
                    SqlDateTime d = new SqlDateTime(Convert.ToInt32(venc.Split('/')[2].Split(' ')[0]), Convert.ToInt32(venc.Split('/')[1]), Convert.ToInt32(venc.Split('/')[0]));

                    if (this.Fecha.CompareTo(d) > 0)
                    {
                       MessageBox.Show("Paso la fecha limite para devolucion");
                       return true; 
                    }
                }

            
            return false;
        }
    }
}
