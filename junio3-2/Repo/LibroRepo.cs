using junio3_2.ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace junio3_2.Repo
{
    public class LibroRepo
    {
        public static void Insertar(Libro lib)
        {
            using (var database = new entity())
            {
                using (var transaccion = database.Database.BeginTransaction())
                {
                    try
                    {
                        database.Libro.Add(lib);
                        database.SaveChanges(); // se guarda en la base de datos pero para la sesion actual
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                    }
                    //para este caso, no es necesario hacer el try catch por que automaticamente ya lo hace o sea tira el rollback si no resulta
                }
            }

        }
    }
}