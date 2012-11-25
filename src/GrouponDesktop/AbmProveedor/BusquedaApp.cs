using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Linq.SqlClient;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.AbmProveedor
{
    public class BusquedaApp
    {
        private string _razonSoc = null;
        
        public string RazonSoc
        {
            get { return _razonSoc; }
            set { _razonSoc = value; }
        }
        private string _cuit = null;

        public string Cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }
        private string _Mail = null;

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }

        

        

        public DataTable buscar()
        {   
            DataTable tabla = new DataTable();
            if ((this.RazonSoc == null || this.RazonSoc == "") && (this.Mail == null || this.Mail == "") && (this.Cuit == null || this.Cuit == ""))
            {
                MessageBox.Show("Error: Debe al menos completar un filtro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Conexion cnn = Conexion.Instance;

                System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

                comando1.CommandType = CommandType.StoredProcedure;
                int contador = 0;
                if (this.Cuit != null && this.Cuit != "")
                {
                    comando1.Parameters.Add("@cuit", SqlDbType.NVarChar);
                    comando1.Parameters[contador].Value = this.Cuit;
                    contador++;
                }

                if (this.RazonSoc != null && this.RazonSoc != "")
                {
                    comando1.Parameters.Add("@razonSoc", SqlDbType.NVarChar);
                    comando1.Parameters[contador].Value = this.RazonSoc;
                    contador++;
                }

                if (this.Mail != null && this.Mail!= "")
                {
                    comando1.Parameters.Add("@mail", SqlDbType.NVarChar);
                    comando1.Parameters[contador].Value = this.Mail;
                    contador++;
                }

                comando1.CommandText = "TRANSA_SQL.filtrarProveedor";

                

                tabla = cnn.ejecutarQueryConSP(comando1);
             }
                
            
            return tabla;
        }
    }
}
