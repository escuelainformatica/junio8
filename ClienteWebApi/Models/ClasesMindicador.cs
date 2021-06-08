using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteWebApi.Models
{
    public class Serie
    {
        public DateTime fecha { get; set; }
        public double valor { get; set; }
    }

    public class ClaseRaiz
    {
        public string version { get; set; }
        public string autor { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public List<Serie> serie { get; set; }
    }

}