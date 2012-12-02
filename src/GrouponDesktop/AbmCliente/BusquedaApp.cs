using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.AbmCliente
{
    class BusquedaApp
    {
        private string _nombre = null;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _apellido = null;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        
        private string _Mail = null;

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }

        private string _dni = null;

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public DataTable buscar()
        {
            DataTable tabla = new DataTable();
            if ((this.Nombre == null || this.Nombre == "") && (this.Mail == null || this.Mail == "") && (this.Dni == null || this.Dni == "") && (this.Apellido == null || this.Apellido == ""))
            {
                MessageBox.Show("Error: Debe al menos completar un filtro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Conexion cnn = Conexion.Instance;

                System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

                comando1.CommandType = CommandType.StoredProcedure;
                int contador = 0;
                if (this.Dni != null && this.Dni != "")
                {
                    comando1.Parameters.Add("@dni", SqlDbType.NVarChar);
                    comando1.Parameters[contador].Value = this.Dni;
                    contador++;
                }

                if (this.Nombre != null && this.Nombre!= "")
                {
                    comando1.Parameters.Add("@nombre", SqlDbType.NVarChar);
                    comando1.Parameters[contador].Value = this.Nombre;
                    contador++;
                }

                if (this.Mail != null && this.Mail != "")
                {
                    comando1.Parameters.Add("@mail", SqlDbType.NVarChar);
                    comando1.Parameters[contador].Value = this.Mail;
                    contador++;
                }

                if (this.Dni != null && this.Dni != "")
                {
                    comando1.Parameters.Add("@dni", SqlDbType.NVarChar);
                    comando1.Parameters[contador].Value = this.Dni;
                    contador++;
                }

                comando1.CommandText = "TRANSA_SQL.filtrarCliente";

                tabla = cnn.ejecutarQueryConSP(comando1);
            }

            return tabla;
        }
    }
}
