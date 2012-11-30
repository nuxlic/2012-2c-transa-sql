using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.AbmCliente
{
    public class ModifClienteApp
    {
        
         public ModifClienteApp(DataGridViewRow row)
        {
            
            this.currentRow = row;
            this.Dni = this.currentRow.Cells[1].Value.ToString();
            this.Mail = this.currentRow.Cells[2].Value.ToString();
            this.Phone = this.currentRow.Cells[3].Value.ToString();
            this.Address = this.currentRow.Cells[4].Value.ToString();
            this.PostalCode = this.currentRow.Cells[5].Value.ToString();
            this.Nombre = this.currentRow.Cells[6].Value.ToString();
            this.Apellido = this.currentRow.Cells[7].Value.ToString();
            this.FechaNac = this.currentRow.Cells[8].Value.ToString();
            
        }

         public ModifClienteApp(DataRow row)
        {
            
            this.currentDataRow = row;
            this.Dni = this.currentDataRow[0].ToString();
            this.Mail = this.currentDataRow[1].ToString();
            this.Phone = this.currentDataRow[2].ToString();
            this.Address = this.currentDataRow[3].ToString();
            this.PostalCode = this.currentDataRow[4].ToString();
            this.Nombre = this.currentDataRow[5].ToString();
            this.Apellido = this.currentDataRow[6].ToString();
            this.FechaNac = this.currentDataRow[7].ToString();
            
        }

         private DataGridViewRow currentRow;
         private DataRow currentDataRow;
        
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private string _dni;

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        private string _mail;

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _postalCode;

        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
        private string _fechaNac;

        public string FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        public void modificar()
        {
            if (this.Apellido == null || this.Apellido == "" || this.PostalCode == null || this.PostalCode == "" || this.Nombre == null || this.Nombre == "" || this.Address == null || this.Address == "" || this.Mail == null || this.Mail == "" ||  this.Dni == null || this.Dni == "" || this.FechaNac == null || this.FechaNac == "" || this.Phone == null || this.Phone == "")
            {
                MessageBox.Show("Error: No debe dejar campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                Conexion cnn = Conexion.Instance;

                System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

                comando1.CommandType = CommandType.StoredProcedure;
                int contador = 0;

                comando1.Parameters.Add("@apellido", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.Apellido;
                contador++;


                comando1.Parameters.Add("@dni", SqlDbType.Decimal);
                comando1.Parameters[contador].Precision = 18;
                comando1.Parameters[contador].Scale = 0;
                comando1.Parameters[contador].Value = this.Dni;
                contador++;

                comando1.Parameters.Add("@mail", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.Mail;
                contador++;

                comando1.Parameters.Add("@phone", SqlDbType.Decimal);
                comando1.Parameters[contador].Precision = 18;
                comando1.Parameters[contador].Scale = 0;
                comando1.Parameters[contador].Value = this.Phone;
                contador++;

                comando1.Parameters.Add("@addr", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.Address;
                contador++;

                comando1.Parameters.Add("@postalCode", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.PostalCode;
                contador++;

                comando1.Parameters.Add("@nombre", SqlDbType.NVarChar);
                comando1.Parameters[contador].Value = this.Nombre;
                contador++;

                comando1.Parameters.Add("@fechaNac", SqlDbType.DateTime);
                comando1.Parameters[contador].Value = this.FechaNac;
                contador++;

                
                comando1.CommandText = "TRANSA_SQL.modificarCliente";


                cnn.ejecutarQueryConSP(comando1);

                MessageBox.Show("Los datos han sido cargados con exito");
            }
        }

        public void setCitys(int dni, List<string> checkedCitys)
        {
            if (checkedCitys.Count == 0)
            {
                MessageBox.Show("Error: No debe dejar campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StringBuilder getCustomerId = new StringBuilder();
                getCustomerId.AppendFormat("SELECT CustomerId FROM TRANSA_SQL.Customer C WHERE C.Dni={0} ", dni);
                int customerId = (int)Conexion.Instance.ejecutarQuery(getCustomerId.ToString()).Rows[0][0];

                Conexion cnn = Conexion.Instance;
                System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
                comando1.CommandType = CommandType.StoredProcedure;

                comando1.Parameters.Add("@CustomerId", SqlDbType.Int);
                comando1.Parameters[0].Value = customerId;
                comando1.CommandText = "TRANSA_SQL.eliminarCiudades";
                cnn.ejecutarQueryConSP(comando1);


                System.Data.SqlClient.SqlCommand comando2 = new System.Data.SqlClient.SqlCommand();
                comando2.CommandType = CommandType.StoredProcedure;

                comando2.Parameters.Add("@CustomerId", SqlDbType.Int);
                comando2.Parameters[0].Value = customerId;
                comando2.CommandText = "TRANSA_SQL.insertarCiudad";
                comando2.Parameters.Add("@CityName", SqlDbType.NVarChar);

                foreach (string city in checkedCitys)
                {
                    comando2.Parameters[1].Value = city;
                    cnn.ejecutarQueryConSP(comando2);
                }
            }
        }
        public List<string> getCitys()
        {
            List<string> strings = new List<string>();

            StringBuilder sentence = new StringBuilder();
            sentence.Append("SELECT * FROM TRANSA_SQL.City");
            DataTable table = Conexion.Instance.ejecutarQuery(sentence.ToString());

            for (int i = 0; i < table.Rows.Count; i++)
            {
                strings.Add(table.Rows[i]["Name"].ToString());
            }

            return strings;
        }

        public List<string> getCheckedCitys(int dni)
        {
            List<string> strings = new List<string>();

            StringBuilder sentence1 = new StringBuilder();
            sentence1.AppendFormat("SELECT CustomerId FROM TRANSA_SQL.Customer C WHERE C.Dni={0} ", dni);
            int customerId = (int)Conexion.Instance.ejecutarQuery(sentence1.ToString()).Rows[0][0];

            StringBuilder sentence2 = new StringBuilder();
            sentence2.AppendFormat("SELECT Name FROM TRANSA_SQL.CustomerCity CC JOIN TRANSA_SQL.City C ON CC.CityId=C.CityID WHERE CustomerId={0} ", customerId);
            DataTable table = Conexion.Instance.ejecutarQuery(sentence2.ToString());

            for (int i = 0; i < table.Rows.Count; i++)
            {
                strings.Add(table.Rows[i]["Name"].ToString());
            }

            return strings;
        }
    }
}
