using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GrouponDesktop.Commons.Database;

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

        public bool createCustomer(string name, string surname, string dni, string email, string phone, string address, string postalcode, DateTime birthday, List<string> cities)
        {
            StringBuilder sentence = new StringBuilder();
            sentence.Append("SELECT * FROM TRANSA_SQL.City");
            DataTable table = connSql.ejecutarQuery(sentence.ToString());
            return true;
        }
    }
}
