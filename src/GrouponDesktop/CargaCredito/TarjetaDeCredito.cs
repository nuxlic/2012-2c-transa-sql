using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.CargaCredito
{
    class TarjetaDeCredito
    {
        private String _Usuario;

        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public TarjetaDeCredito(String user)
        {
            this.Usuario = user;

        }

    }
}
