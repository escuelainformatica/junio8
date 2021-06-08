using junio3_2.ef;
using junio3_2.Repo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace junio3_2.Controllers
{
    public class Default1Controller : Controller
    {
        // GET: Default1
        [HttpGet]
        public ActionResult Insertar()
        {
            var lib = new Libro();

            return View(lib);
        }
        [HttpPost]
        public ActionResult Insertar(Libro lib)
        {
            LibroRepo.Insertar(lib);
            return View(lib);
        }
        public ActionResult Procedimiento()
        {
            var autor=new Autor();
            autor.Nombre="ejemplo";
            AutorRepo.Insertar(autor);
            return null;
        }
    }
}