using junio3_2.ef;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public static int Insertar(Autor autor)
        {
            var resultado=0;
            var datos=new Autor();
            using (var database = new entity())
            {
                var paramNombre=new SqlParameter();
                paramNombre.Value=autor.Nombre;
                paramNombre.ParameterName="nombre";
                paramNombre.SqlDbType=System.Data.SqlDbType.VarChar;
                paramNombre.Size=50;
                paramNombre.Direction=System.Data.ParameterDirection.Input; // c# --> sqlserver    output sql-->c#  

                datos=database.Database
                    .SqlQuery<Autor>("exec sp_crear_autor @nombre",paramNombre)
                    .First();

            }
            return datos.IdAutor;
        }
    }
}