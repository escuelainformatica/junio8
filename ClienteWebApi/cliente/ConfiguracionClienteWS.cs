using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteWebApi.cliente
{
    public class ConfiguracionClienteWS
    {
        #if DEBUG
        public const string PUERTO="http://localhost:53957/api/";
        #else
        public const string PUERTO="http://www.dominio.dom/api/";
        #endif
    }
}