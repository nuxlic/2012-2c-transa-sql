using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace GrouponDesktop.ListadoEstadistico
{
    public interface IListadoModel
    {
        DataTable listar(int semestre, int anio); 
    }
}
