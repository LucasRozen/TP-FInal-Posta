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
            
            ViewBag.ListarEve = BD.ListarTipoEve();
            return View();
        }

        public ActionResult EventosXCategoria(int IdCategoria, string NombreEve)
        {
         
            ViewBag.TipEve = NombreEve;
            ViewBag.Eventos = BD.TraerXTipEve(IdCategoria);
            return View("EventosXCategoria");
        }

      

     
    }
}