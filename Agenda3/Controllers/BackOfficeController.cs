using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agenda3.Models;

namespace Agenda3.Controllers
{
    public class BackOfficeController : Controller
    {
        // GET: BackOffice
        public ActionResult Index()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListaAmigos = BD.ListarAmigos();
            return View();
        }
        public ActionResult Eventos()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarEventos = BD.ListarEventos();
            return View();
        }
        public ActionResult Amigos()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListaAmigos = BD.ListarAmigos();
            return View();
        }
        public ActionResult TiposEve()
        {
            ViewBag.ListarTipos = BD.ListarTipoEve();
            return View();
        }
        public ActionResult AgregarAmigo()
        {
            return View();
        }
        public ActionResult InsertarAmigo(Amigos a)
        {
            BD.AgregarAmigo(a.Nombre);
            return RedirectToAction("Index", "BackOffice");
        }

    }
}