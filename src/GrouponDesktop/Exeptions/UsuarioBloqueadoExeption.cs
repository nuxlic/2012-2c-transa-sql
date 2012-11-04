using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Exeptions
{
    class UsuarioBloqueadoExeption: System.ApplicationException
    {
        
    
        public UsuarioBloqueadoExeption() {}
        public UsuarioBloqueadoExeption(string message) {}
        public UsuarioBloqueadoExeption(string message, System.Exception inner) {}
 
        // Constructor needed for serialization 
        // when exception propagates from a remoting server to the client.
        protected UsuarioBloqueadoExeption(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) {}
    }
}
