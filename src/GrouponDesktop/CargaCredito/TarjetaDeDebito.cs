using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.CargaCredito
{
    class TarjetaDeDebito
    {
        private String _Usuario;

        public String Usuario
        {
          get { return _Usuario; }
          set { _Usuario = value; }
        }
        public TarjetaDeDebito(String user)
        {
            this.Usuario = user;
        }
    }
}
