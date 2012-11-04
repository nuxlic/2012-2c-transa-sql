using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Commons.Database.Repositorios
{
    interface IRepositorio
    {
        void Insertar(Object objeto);
        void Borrar(Object objeto);
        Object Obtener(Object objeto);
        IList<Object> ObtenerTodos();
        void GuardarCambios();
    }
}
