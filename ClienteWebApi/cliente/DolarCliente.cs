using ClienteWebApi.Models;
using junio3_2.ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web;

namespace ClienteWebApi.cliente
{
    public class DolarCliente
    {
        public static ClaseRaiz Leer()
        {
            var libros=new ClaseRaiz();
            using(var cliente=new HttpClient())
            {
                cliente.BaseAddress=new Uri("https://mindicador.cl/api/");
                var respuesta=cliente.GetAsync("dolar"); // no es asincronica.
                respuesta.Wait();

                HttpResponseMessage result = respuesta.Result;
                if(result.IsSuccessStatusCode) // si la conexion fue exitosa
                {
                    var tarea=result.Content.ReadAsAsync<ClaseRaiz>();
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