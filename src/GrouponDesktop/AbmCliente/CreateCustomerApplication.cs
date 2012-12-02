using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GrouponDesktop.Commons.Database;
using System.Windows.Forms;

namespace GrouponDesktop.AbmCliente
{
    class CreateCustomerApplication
    {
        private Conexion connSql = Conexion.Instance;

        public List<string> getCitys()
        {
            List<string> strings = new List<string>();
            
            StringBuilder sentence= new StringBuilder();
            sentence.Append("SELECT * FROM TRANSA_SQL.City");
            DataTable table = connSql.ejecutarQuery(sentence.ToString());


            for (int i = 0; i < table.Rows.Count; i++)
            {
                strings.Add(table.Rows[i]["Name"].ToString());
            }

            return strings;
        }

        public bool createCustomer(string name, string surname, string dni, string email, string phone, string address, string postalcode, DateTime birthday, List<string> citys)
        {
            if (name == "" || surname == "" || dni == "" || email == "" || phone == "" || address == "" || postalcode == "" || birthday == null || citys.Count == 0)
            {
                MessageBox.Show("Error: No debe dejar campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                Conexion cnn = Conexion.Instance;
                System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
                comando1.CommandType = CommandType.StoredProcedure;

                comando1.Parameters.Add("@Name", SqlDbType.NVarChar);
                comando1.Parameters.Add("@Surname", SqlDbType.NVarChar);
                comando1.Parameters.Add("@Dni", SqlDbType.Int);
                comando1.Parameters.Add("@Email", SqlDbType.NVarChar);
                comando1.Parameters.Add("@PhoneNumber", SqlDbType.Int);
                comando1.Parameters.Add("@Address", SqlDbType.NVarChar);
                comando1.Parameters.Add("@PostalCode", SqlDbType.NVarChar);
                comando1.Parameters.Add("@Birthday", SqlDbType.DateTime);

                comando1.Parameters[0].Value = name;
                comando1.Parameters[1].Value = surname;
                comando1.Parameters[2].Value = dni;
                comando1.Parameters[3].Value = email;
                comando1.Parameters[4].Value = phone;
                comando1.Parameters[5].Value = address;
                comando1.Parameters[6].Value = postalcode;
                comando1.Parameters[7].Value = birthday;

                comando1.CommandText = "TRANSA_SQL.altaCliente";
                cnn.ejecutarQueryConSP(comando1);

                StringBuilder sentence = new StringBuilder();
                sentence.AppendFormat("SELECT C.CustomerId FROM TRANSA_SQL.Customer C WHERE C.Dni={0}", dni);
                int customerId = (int)connSql.ejecutarQuery(sentence.ToString()).Rows[0][0];

                System.Data.SqlClient.SqlCommand comando2 = new System.Data.SqlClient.SqlCommand();
                comando2.CommandType = CommandType.StoredProcedure;

                comando2.Parameters.Add("@CustomerId", SqlDbType.Int);
                comando2.Parameters.Add("@CityName", SqlDbType.NVarChar);
                comando2.CommandText = "TRANSA_SQL.insertarCiudad";
                comando2.Parameters[0].Value = customerId;

                foreach (string city in citys)
                {
                    comando2.Parameters[1].Value = city;
                    cnn.ejecutarQueryConSP(comando2);
                }
                return true;
            }
        }

        public void validarSoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void validarSoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void validarSoloLetrasYnumeros(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void validarMail(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '@')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '_')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
