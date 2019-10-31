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
            
            ViewBag.ListarEve = BD.ListarEve();
            return View();
        }

        public ActionResult EventosXCategoria(int IdCategoria, string NombreEve)
        {
         
            ViewBag.TipEve = NombreEve;
            ViewBag.Eventos = BD.TraerXTipEve(IdCategoria);
            return View("EventosXCategoria");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

     
    }
}