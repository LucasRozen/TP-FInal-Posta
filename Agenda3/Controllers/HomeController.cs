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
       
        public ActionResult EventosXCategoria(int IdCategoria, string NombreEve)
        {
            ViewBag.ListarEventos = BD.ListarEventos();
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.TipEve = NombreEve;
            ViewBag.Eventos = BD.TraerXTipEve(IdCategoria);
            return View("EventosXCategoria");
        }
        public ActionResult DetalleEve(int IdEve, string Nombre)
        {
            ViewBag.ListarEventos = BD.ListarEventos();
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.Elegido = BD.TraerUnEvento(IdEve);
            return View("DetalleEve");
        }
        public ActionResult Amigos()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListaAmigos = BD.ListarAmigos();
            return View("Amigos");
        }

    }
}