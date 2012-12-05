using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Cryptography;
using GrouponDesktop.Commons.Database;
using GrouponDesktop.Exeptions;
using System.Numeric;
using System.Data;
using System.Windows.Forms;

namespace GrouponDesktop
{
    class LoginApplication
    {
        private string _Username = null;
        private string _Password = null;
        private Conexion connSqlClient = Conexion.Instance;
        private int intentosFallidos = 0;
        private DataRow _UserRow;

        public DataRow UserRow
        {
            get { return _UserRow; }
            set { _UserRow = value; }
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

        private MainForm _mainWindow;

        public MainForm MainWindow
        {
            get { return _mainWindow; }
            set { _mainWindow = value; }
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

        public string loguearse()
        {
            
                string passHasheada = encriptarPassword(Password);
                StringBuilder sentence=new StringBuilder().Append("select * from TRANSA_SQL.CuponeteUser cu where cu.Username='").Append(this.Username).Append("' and cu.Password='").Append(passHasheada).Append("'");
                DataTable table=connSqlClient.ejecutarQuery(sentence.ToString());
                if (table.Rows.Count > 0)
                {
                    this.UserRow = table.Rows[0];
                    if ((bool)table.Rows[0]["Enabled"]==false)
                    {
                        throw new UsuarioBloqueadoExeption("El usuario esta bloqueado por mas de 3 intentos fallidos, contacte con el administrador");
                    }
                    if ((bool)table.Rows[0]["Deleted"] == true)
                    {
                        throw new UsuarioDadoDeBajaExeption();
                    }

                    if (intentosFallidos >= 3)
                    {
                        this.intentosFallidos = 0;
                        this.bloquearUsuario(table.Rows[0]);
                    }
                    Conexion cnn = Conexion.Instance;

                    System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();

                    comando1.CommandType = CommandType.StoredProcedure;
                    this.MainWindow.TipoUsuario = this.getTipoUsuario(table.Rows[0]);
                    if ((bool)table.Rows[0]["FirstLogin"])
                    {
                        if ((int)table.Rows[0]["RoleId"] == 3)
                        {
                            comando1.Parameters.Add("@userid", SqlDbType.Int);
                            comando1.Parameters[0].Value = table.Rows[0]["UserId"];
                            comando1.CommandText = "TRANSA_SQL.filtrarProveedor";
                            DataTable tabla = cnn.ejecutarQueryConSP(comando1);

                            new Login.FirstLoginForm(tabla.Rows[0], this.MainWindow, (int)table.Rows[0]["RoleId"], (int)table.Rows[0]["UserId"]).Show();


                        }
                        else if ((int)table.Rows[0]["RoleId"] == 2)
                        {
                            comando1.Parameters.Add("@userid", SqlDbType.Int);
                            comando1.Parameters[0].Value = table.Rows[0]["UserId"];
                            comando1.CommandText = "TRANSA_SQL.filtrarCliente";
                            DataTable tabla = cnn.ejecutarQueryConSP(comando1);
                            new Login.FirstLoginForm(tabla.Rows[0], this.MainWindow, (int)table.Rows[0]["RoleId"], (int)table.Rows[0]["UserId"]).Show();
                        }

                    }
                    else
                    {
                        
                        this.MainWindow.Show();
                    }
                    
                    
                }
                else
                {
                    this.incrementarIntentosFallidos();
                    throw new AccesoNoConcedidoExeption("Usuario o contraseña incorrecta");
                }
                return this.getTipoUsuario(table.Rows[0]);
        }

        public void incrementarIntentosFallidos()
        {
            intentosFallidos++;
        }

        public void bloquearUsuario(DataRow row)
        {
            StringBuilder sentence = new StringBuilder().Append("Update TRANSA_SQL.CuponeteUser set FailedAttemps=3,[Enabled]=0 where Username='").Append(row["Username"].ToString()).Append("' and Password='").Append(row["Password"].ToString()).Append("'");
            connSqlClient.ejecutarQuery(sentence.ToString());
            throw new UsuarioBloqueadoExeption();
        }

        public string getTipoUsuario(DataRow row)
        {
            StringBuilder sentence = new StringBuilder().Append("select * from TRANSA_SQL.Role r where r.RoleId=").Append(row["RoleId"]) ;
            DataTable tabla = connSqlClient.ejecutarQuery(sentence.ToString());
            return (string)tabla.Rows[0]["Name"];
            
        }
    }
}
