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
        void ponerlistar()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarEventos = BD.ListarEventos();
        }
        // GET: BackOffice
        public ActionResult Index()
        {
            ponerlistar();
            return View();
        }
        public ActionResult Eventos()
        {
            ponerlistar();
            return View();
        }
        public ActionResult Amigos()
        {
            ponerlistar();
            return View();
        }
        public ActionResult TiposEve()
        {
            ponerlistar();
            return View();
        }
        public ActionResult AgregarAmigo()
        {
            ponerlistar();
            return View();
        }
        public ActionResult InsertarAmigo(Amigos ami)
        {
            BD.AgregarAmigo(ami.Nombre, ami.Activo); 
            return RedirectToAction("Amigos", "Home");
            // return View("Amigos");
        }
        public ActionResult AgregarEvento()
        {
            ponerlistar();
            return View();
        }
        public ActionResult AgregarTipo()
        {
            ponerlistar();
            return View();
        }

    }
}