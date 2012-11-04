using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using GrouponDesktop.Commons.Database;
using GrouponDesktop.Commons.Database.DTO;
using GrouponDesktop.Exeptions;
using System.Data;
using System.Data.SqlClient;
using System.Numeric;
namespace GrouponDesktop
{
    class LoginApplication
    {
        private string _Username = null;

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        private string _Password = null;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private GenericDAO dao=new GenericDAO();
        private DTOCuponeteUser DTOUser = new DTOCuponeteUser();
        private DataTable dt = null;
        
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

        public void loguearse()
        {
            string passHasheada = encriptarPassword(Password);
            DTOUser.Username = Username;
            DTOUser.Password = passHasheada;
            dt=dao.select(DTOUser,null,null).Tables[0];
            if (dt.Rows.Count <= 0)
            {
                this.incrementarIntentosFallidos();
                throw new AccesoNoConcedidoExeption("Usuario o contraseña incorrecta");
                
            }
        }

        public void incrementarIntentosFallidos()
        {
            //todo implementar
        }

    }
}
