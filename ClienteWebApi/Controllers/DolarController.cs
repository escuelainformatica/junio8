using ClienteWebApi.cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClienteWebApi.Controllers
{
    public class DolarController : Controller
    {
        // GET: Dolar
        public ActionResult Index()
        {
            var dolar=DolarCliente.Leer();

            return View();
        }
    }
}