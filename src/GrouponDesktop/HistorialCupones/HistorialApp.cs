using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.HistorialCupones
{
    public class HistorialApp
    {
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private DateTime _fecha1;

        public DateTime Fecha1
        {
            get { return _fecha1; }
            set { _fecha1 = value; }
        }

        private DateTime _fecha2;

        public DateTime Fecha2
        {
            get { return _fecha2; }
            set { _fecha2 = value; }
        }

        //public DataTable mostrarHistorial()
        //{

        //}
    }
}
