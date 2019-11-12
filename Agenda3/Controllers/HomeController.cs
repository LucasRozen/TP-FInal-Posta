using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agenda3.Models;

namespace Agenda3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ListarEventos = BD.ListarEventos();
            ViewBag.ListarEve = BD.ListarTipoEve();
            return View();
        }
        public AtionResult BackOffice()
        {
            return view;
        }
        public ActionResult EventosXCategoria(int IdCategoria, string NombreEve)
        {        
            ViewBag.TipEve = NombreEve;
            ViewBag.Eventos = BD.TraerXTipEve(IdCategoria);
            return View("EventosXCategoria");
        }
        public ActionResult ListarAmigos()
        {        
            ViewBag.ListaAmigos = BD.ListarAmigos();
            return View("Amigos");
        }

    }
}