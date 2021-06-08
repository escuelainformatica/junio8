using junio3_2.ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web;

namespace ClienteWebApi.cliente
{
    public class LibroCliente
    {
        public static List<Libro> Leer()
        {
            var libros=new List<Libro>();
            using(var cliente=new HttpClient())
            {
                cliente.BaseAddress=new Uri(ConfiguracionClienteWS.PUERTO);
                var respuesta=cliente.GetAsync("LibroApi"); // no es asincronica.
                respuesta.Wait();

                HttpResponseMessage result = respuesta.Result;
                if(result.IsSuccessStatusCode) // si la conexion fue exitosa
                {
                    var tarea=result.Content.ReadAsAsync<List<Libro>>();
                    libros=tarea.Result;
                } else
                {
                    libros=null;
                }
            }
            return libros;
        }
    }
}