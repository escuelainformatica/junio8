using junio3_2.ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace junio3_2.Repo2
{
    public class AutorRepo
    {
        public static List<Autor> Listar()
        {
            var resultado = new List<Autor>();
            using (var database = new entity())
            {
                resultado = database.Autor.ToList();
            }
            return resultado;
        }
    }
}