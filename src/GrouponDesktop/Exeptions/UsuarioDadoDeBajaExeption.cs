using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Exeptions
{
    class UsuarioDadoDeBajaExeption : System.ApplicationException
    {
        public UsuarioDadoDeBajaExeption() {}
        public UsuarioDadoDeBajaExeption(string message) {}
        public UsuarioDadoDeBajaExeption(string message, System.Exception inner) {}
 
        // Constructor needed for serialization 
        // when exception propagates from a remoting server to the client.
        protected UsuarioDadoDeBajaExeption(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) {}
    }
}
