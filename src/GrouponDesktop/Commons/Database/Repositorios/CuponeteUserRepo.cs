using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Linq;
using System.Data.Linq.Mapping;
using GrouponDesktop.Commons.Database.Entidades;

namespace GrouponDesktop.Commons.Database.Repositorios
{
    class CuponeteUserRepo
    {
        private DataContext _db=Conexion.getInstance.getDB();
        private Table<CuponeteUser> _CuponeteUser;

        public CuponeteUserRepo()
        {
            _CuponeteUser = _db.GetTable<CuponeteUser>();
        }

        public void Insertar(CuponeteUser cuponeteUser)
        {
            _CuponeteUser.InsertOnSubmit(cuponeteUser);
        }
 
        public void Borrar(CuponeteUser cuponeteUser)
        {
            _CuponeteUser.DeleteOnSubmit(cuponeteUser);
        }
         
        public CuponeteUser Obtener(int UserId)
        {
            return _CuponeteUser.Single(l => l.UserId == UserId);
        }

        public CuponeteUser Obtener(int UserId, string Username)
        {
            return _CuponeteUser.Single(u => u.UserId == UserId && u.Username==Username);
        }

        public CuponeteUser Obtener(int UserId, string Username, string Password)
        {
            return _CuponeteUser.Single(u => u.UserId == UserId && u.Username == Username && u.Password==Password);
        }

        public CuponeteUser Obtener(string Username, string Password)
        {
            return _CuponeteUser.Single(u => u.Username == Username && u.Password == Password);
        }

        public CuponeteUser Obtener(string Username)
        {
            return _CuponeteUser.Single(u => u.Username == Username);
        }
         
        public IList<CuponeteUser> ObtenerTodos()
        {
            return _CuponeteUser.ToList();
        }
         
        public void GuardarCambios()
        {
            _db.SubmitChanges();
        }
    }
}
