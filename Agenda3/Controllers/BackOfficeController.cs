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
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos=BD.ListarTipoEve();
            return View();
        }

        //AMIGOS
        public ActionResult AgregarAmigo()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            return View();
        }
        public ActionResult InsertarAmigo(Amigos ami)
        {
            BD.AgregarAmigo(ami.Nombre, ami.Activo); 
            return RedirectToAction("Amigos", "BackOffice");
        }
        public ActionResult EliminarAmigo(int id)
        {
            BD.EliminarAmigo(id);
            return RedirectToAction("Amigos", "BackOffice");
        }
        public ActionResult EditarAmigo(Amigos ami)
        {
            BD.EditarAmigo(ami.Nombre, ami.IdAmigo);
            return RedirectToAction("Amigos", "BackOffice");
        }
        public ActionResult EditoAmigo(int id)
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            List<Amigos> ami = BD.ListarAmigos();
            Amigos am = new Amigos();
            foreach(Amigos a in ami)
            {
                if(a.IdAmigo == id)
                {
                    am.IdAmigo = a.IdAmigo;
                    am.Nombre = a.Nombre;
                }
            }           
            return View(am);
        }

        //EVENTOS
        public ActionResult AgregarEvento()
        {
            ViewBag.ListarAmigo = BD.ListarAmigos();
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            return View();
        }
        public ActionResult InsertarEvento(Evento eve)
        {
            BD.AgregarEvento(eve.Nombre,eve.IdTipEve, eve.IdAmigo,eve.Dia, eve.Descripcion, eve.Activo, eve.Destac);
            return RedirectToAction("Eventos", "BackOffice");
        }
        public ActionResult EliminarEvento(int id)
        {
            BD.EliminarEvento(id);
            return RedirectToAction("Eventos", "BackOffice");
        }
        public ActionResult EditoEvento(Evento eve, int id)
        {
            ViewBag.ListarAmigo = BD.ListarAmigos();
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            BD.EditarEvento(eve.Nombre, eve.IdTipEve, eve.IdAmigo, eve.Dia, eve.Descripcion, eve.Activo, eve.Destac, id);
            return RedirectToAction("Eventos", "BackOffice");
        }
        public ActionResult EditarEvento(int id)
        {
            ViewBag.ListaAmigos = BD.ListarAmigos();
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            List<Evento> Eve = BD.ListarEventos();
            Evento ev = new Evento();
            foreach (Evento a in Eve)
            {
                if (a.IdEve == id)
                {
                    ev = a;
                }
            }
            return View(ev);
        }

        // TIPOS
        public ActionResult AgregarTipo()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            return View();
        }        
        public ActionResult InsertarTipo(TiposEve tip)
        {
            BD.AgregarTipo(tip.TipEve);
            return RedirectToAction("TiposEve", "BackOffice");
        }
        public ActionResult EliminarTipo(int id)
        {
            BD.EliminarTipo(id);
            return RedirectToAction("TiposEve", "BackOffice");
        }
        public ActionResult EditoTipos(TiposEve tps, int id)
        {
            ViewBag.ListarAmigo = BD.ListarAmigos();
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            BD.EditarTipo(tps.TipEve, id);
            return View();
        }
        public ActionResult EditarTipo()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            return RedirectToAction("TiposEve", "BackOffice");
        }

    }
}