using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Exeptions
{
    class AccesoNoConcedidoExeption : System.ApplicationException
    {
        public AccesoNoConcedidoExeption() {}
        public AccesoNoConcedidoExeption(string message) {}
        public AccesoNoConcedidoExeption(string message, System.Exception inner) {}
 
        // Constructor needed for serialization 
        // when exception propagates from a remoting server to the client.
        protected AccesoNoConcedidoExeption(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) {}
    }
}
