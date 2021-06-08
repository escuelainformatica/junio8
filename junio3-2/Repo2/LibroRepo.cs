using junio3_2.ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace junio3_2.Repo2
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
                        database.SaveChanges();
                        transaccion.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                    }
                }
            }

        }
        public static List<Libro> GetAll()
        {
            var list = new List<Libro>();

            using(var db = new entity())
            {
                db.Configuration.ProxyCreationEnabled=false;
                list = db.Libro.Include("Autor").ToList();
            }
            return list;
        }

    }
}