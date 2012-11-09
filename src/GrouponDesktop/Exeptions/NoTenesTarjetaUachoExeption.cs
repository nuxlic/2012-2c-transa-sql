using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Exeptions
{
    class NoTenesTarjetaUachoExeption : System.ApplicationException
    {
         public NoTenesTarjetaUachoExeption() {}
        public NoTenesTarjetaUachoExeption(string message) {}
        public NoTenesTarjetaUachoExeption(string message, System.Exception inner) {}
 
        // Constructor needed for serialization 
        // when exception propagates from a remoting server to the client.
        protected NoTenesTarjetaUachoExeption(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) {}
    }
}
