using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Cryptography;
using GrouponDesktop.Commons.Database;
using GrouponDesktop.Exeptions;
using System.Numeric;
using System.Data;

namespace GrouponDesktop
{
    class LoginApplication
    {
        private string _Username = null;
        private string _Password = null;
        private Conexion connSqlClient = Conexion.Instance;
        private int intentosFallidos = 0;
        
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
       
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        
        
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
                StringBuilder sentence=new StringBuilder().Append("select * from TRANSA_SQL.CuponeteUser cu where cu.Username='").Append(this.Username).Append("' and cu.Password='").Append(passHasheada).Append("'");
                DataTable table=connSqlClient.ejecutarQuery(sentence.ToString());
                if (table.Rows.Count > 0)
                {
                    if ((bool)table.Rows[0]["Enabled"]==false)
                    {
                        throw new UsuarioBloqueadoExeption("El usuario esta bloqueado por mas de 3 intentos fallidos, contacte con el administrador");
                    }

                    if (intentosFallidos >= 3)
                    {
                        this.bloquearUsuario(table.Rows[0]);
                    }
                }
                else
                {
                    this.incrementarIntentosFallidos();
                    throw new AccesoNoConcedidoExeption("Usuario o contraseña incorrecta");
                }
           
        }

        public void incrementarIntentosFallidos()
        {
            intentosFallidos++;
        }

        public void bloquearUsuario(DataRow row)
        {
            StringBuilder sentence = new StringBuilder().Append("Update TRANSA_SQL.CuponeteUser set FailedAttemps=3,[Enabled]=0 where Username='").Append(row["Username"].ToString()).Append("' and Password='").Append(row["Password"].ToString()).Append("'");
            connSqlClient.ejecutarQuery(sentence.ToString());
        }
    }
}
