using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenda3.Controllers
{
    public class BackOfficeController : Controller
    {
        // GET: BackOffice
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Eventos()
        {
            ViewBag.ListarEventos = BD.ListarEventos();
            return View;
        }
        public ActionResult Amigos()
        {
            ViewBag.ListaAmigos = BD.ListarAmigos();
            return View;
        }
    }
}