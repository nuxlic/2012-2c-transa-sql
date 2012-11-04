using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;


namespace GrouponDesktop.Commons.Database
{
    class Conexion
    {
        private static Conexion instance;
        private Conexion() { }
        
        public static Conexion getInstance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new Conexion();
                }
                return instance;
            }
        }

        

        private DataContext _db = new DataContext(System.Configuration.ConfigurationManager.ConnectionStrings["gd"].ConnectionString);

        public DataContext getDB()
        {
            return _db;
        }
    }
}
