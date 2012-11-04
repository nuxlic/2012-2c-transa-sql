using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Cryptography;
using GrouponDesktop.Commons.Database;
using GrouponDesktop.Commons.Database.Entidades;
using GrouponDesktop.Commons.Database.Repositorios;
using GrouponDesktop.Exeptions;
using System.Numeric;

namespace GrouponDesktop
{
    class LoginApplication
    {
        private string _Username = null;
        private string _Password = null;
        private CuponeteUserRepo _UserRepo = new CuponeteUserRepo();
        private int intentosFallidos = 0;

        internal CuponeteUserRepo UserRepo
        {
            get { return _UserRepo; }
            set { _UserRepo = value; }
        }
        
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
            try
            {
                string passHasheada = encriptarPassword(Password);
                CuponeteUser table = this.UserRepo.Obtener(this.Username, passHasheada);
                if (table.Enabled = false)
                {
                    throw new UsuarioBloqueadoExeption("El usuario esta bloqueado por mas de 3 intentos fallidos, contacte con el administrador");
                }
                
                if (intentosFallidos >= 3)
                {
                    this.bloquearUsuario(table);
                }
            }
            catch(InvalidOperationException ex){
                this.incrementarIntentosFallidos();
                throw new AccesoNoConcedidoExeption("Usuario o contraseña incorrecta");
                
            }
        }

        public void incrementarIntentosFallidos()
        {
            intentosFallidos++;
        }

        public void bloquearUsuario(CuponeteUser usuario)
        {
            usuario.FailedAttemps = 3;
            usuario.Enabled = false;
            this.UserRepo.GuardarCambios();
        }
    }
}
