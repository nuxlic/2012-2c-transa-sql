using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using GrouponDesktop.Commons.Database;
using GrouponDesktop.Commons.Database.DTO;
using System.Data;
using System.Data.SqlClient;
namespace GrouponDesktop
{
    class LoginApplication
    {
        private string Username = null;

        public string Username1
        {
            get { return Username; }
            set { Username = value; }
        }
        private string Password = null;

        public string Password1
        {
            get { return Password; }
            set { Password = value; }
        }

       private GenericDAO dao=new GenericDAO();
       private DTOCuponeteUser DTOUser = new DTOCuponeteUser();

        public string encriptarPassword(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }

        public bool hashCompare(string aHash, string otherHash)
        {
            return aHash == otherHash;
        }

        public bool loguearse()
        {
            string passHasheada = encriptarPassword(Password1);
            
            DTOUser.Username1 = Username1;
            DTOUser.Password1 = passHasheada;
            DataTable dt=dao.select(DTOUser).Tables[0];
            string passPersistida=dt.Rows[0][1].ToString();
            return hashCompare(passHasheada, passPersistida);

        }

        public void incrementarIntentosFallidos()
        {
            //DTOUser.Insert
        }

    }
}
