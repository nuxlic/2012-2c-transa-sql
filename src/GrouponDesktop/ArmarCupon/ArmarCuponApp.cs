using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.ArmarCupon
{
    public class ArmarCuponApp
    {

        public ArmarCuponApp(ArmarCuponForm own)
        {
            this.owner = own;
        }

        private ArmarCuponForm owner;

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private SqlDateTime _fechaPub;
        
        public SqlDateTime FechaPub
        {
            get { return _fechaPub; }
            set { _fechaPub = value; }
        }
        private SqlDateTime _fechaVencOfer;

        public SqlDateTime FechaVencOfer
        {
            get { return _fechaVencOfer; }
            set { _fechaVencOfer = value; }
        }
        private SqlDateTime _fechaVencCons;

        public SqlDateTime FechaVencCons
        {
            get { return _fechaVencCons; }
            set { _fechaVencCons = value; }
        }
        private string _pReal;

        public string PReal
        {
            get { return _pReal; }
            set { _pReal = value; }
        }
        private string _pFict;

        public string PFict
        {
            get { return _pFict; }
            set { _pFict = value; }
        }
        private string _proveedor;

        public string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }
        private string _stock;

        public string Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        private string _cantMax;

        public string CantMax
        {
            get { return _cantMax; }
            set { _cantMax = value; }
        }
        private List<string> _zonas;

        public List<string> Zonas
        {
            get { return _zonas; }
            set { _zonas = value; }
        }

        public void armar()
        {
            if (this.CantMax == "" || this.CantMax == null || this.Descripcion == "" || this.Descripcion == null || this.PFict == null || this.PFict == "" || this.PReal == null || this.PReal == "" || this.Proveedor == null || this.Proveedor == "" || this.Stock == null || this.Stock == "" || this.Zonas.Count == 0)
            {
                MessageBox.Show("No debe dejar Campos en blanco");
            }
            else if (Int32.Parse(this.CantMax) == 0 || Int32.Parse(this.PReal) == 0 || Int32.Parse(this.PFict) == 0 || Int32.Parse(this.Stock)==0)
            { 
                MessageBox.Show("Debe ingresar valores positivos, no pueden ser 0", "Error al armar cupon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

                comando1.CommandType = CommandType.StoredProcedure;
                int contador = 0;

                comando1.Parameters.Add("@proveedor", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.Proveedor;
                contador++;

                comando1.Parameters.Add("@desc", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.Descripcion;
                contador++;

                comando1.Parameters.Add("@fechapub", SqlDbType.DateTime);
                comando1.Parameters[contador].Value = this.FechaPub;
                contador++;

                comando1.Parameters.Add("@fechavencof", SqlDbType.DateTime);
                comando1.Parameters[contador].Value = this.FechaVencOfer;
                contador++;

                comando1.Parameters.Add("@fechavenccons", SqlDbType.DateTime);
                comando1.Parameters[contador].Value = this.FechaVencCons;
                contador++;

                comando1.Parameters.Add("@pFic", SqlDbType.Decimal);
                comando1.Parameters[contador].Precision = 18;
                comando1.Parameters[contador].Scale = 2;
                comando1.Parameters[contador].Value = this.PFict;
                contador++;

                comando1.Parameters.Add("@pReal", SqlDbType.Decimal);
                comando1.Parameters[contador].Precision = 18;
                comando1.Parameters[contador].Scale = 2;
                comando1.Parameters[contador].Value = this.PReal;
                contador++;

                comando1.Parameters.Add("@stock", SqlDbType.Decimal);
                comando1.Parameters[contador].Precision = 18;
                comando1.Parameters[contador].Scale = 0;
                comando1.Parameters[contador].Value = this.Stock;
                contador++;

                comando1.Parameters.Add("@maxallow", SqlDbType.Int);
                comando1.Parameters[contador].Value = this.CantMax;
                contador++;

                comando1.CommandText = "TRANSA_SQL.armarCupon";
                Conexion.Instance.ejecutarQueryConSP(comando1);

                System.Data.SqlClient.SqlCommand comando2 = new System.Data.SqlClient.SqlCommand();

                comando2.CommandType = CommandType.StoredProcedure;
                contador = 0;

                StringBuilder sentence = new StringBuilder();
                sentence.Append("SELECT C.CouponBookId FROM TRANSA_SQL.CouponBook C order by 1 desc");
                int Id = (int)Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows[0][0];

                comando2.Parameters.Add("@CouponBookId", SqlDbType.Int);
                comando2.Parameters[contador].Value = Id;
                contador++;
                comando2.Parameters.Add("@CityName", SqlDbType.NVarChar);
                comando2.CommandText = "TRANSA_SQL.insertarZonaPerCoupon";
                foreach (string city in this.Zonas)
                {
                    comando2.Parameters[1].Value = city;
                    Conexion.Instance.ejecutarQueryConSP(comando2);
                }

                MessageBox.Show("Ha sido armado con exito");
                this.owner.Close();

            }
        }

    }
}
