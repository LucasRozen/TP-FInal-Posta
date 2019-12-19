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
            BD.AgregarAmigo(ami.Nombre); 
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
            BD.AgregarEvento(eve.Nombre,eve.IdTipEve, eve.IdAmigo, Fecha.fecha, eve.Descripcion,  eve.Destac);
            return RedirectToAction("Eventos", "BackOffice");
        }
        public ActionResult EliminarEvento(int id)
        {
            BD.EliminarEvento(id);
            return RedirectToAction("Eventos", "BackOffice");
        }

        public ActionResult EliminarAmigoEvento(int idEvento, int idAmigo)
        {
            BD.EliminarAmigoEvento(idEvento, idAmigo);
            int id = idEvento;
            return RedirectToAction("DetalleEve","Home", new { idEvento = id });


        }

        public ActionResult EditoEvento(Evento eve)
        {
            
            ViewBag.ListarAmigo = BD.ListarAmigos();
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            BD.EditarEvento(eve.Nombre, eve.IdTipEve, eve.IdAmigo, Fecha.fecha, eve.Descripcion, eve.Destac, eve.IdEve);
            return RedirectToAction("Eventos", "BackOffice");
        }
        public ActionResult EditarEvento(int id)
        {
            ViewBag.ListarAmigos = BD.ListarAmigosXEvento(id);
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
        public ActionResult EditoTipos(int id)
        {
            ViewBag.ListarAmigo = BD.ListarAmigos();
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            List<TiposEve> lista = BD.ListarTipoEve();
            TiposEve untipo = new TiposEve();
            foreach (TiposEve a in lista)
            {
                if (a.IdTipEve == id)
                {
                    untipo = a;
                }
            }
            
            return View(untipo);
        }
        public ActionResult EditarTipo(TiposEve tps)
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            BD.EditarTipo(tps.TipEve, tps.IdTipEve);
            return RedirectToAction("TiposEve", "BackOffice");
        }
        public ActionResult dato(DateTime dato)
        {
            Fecha.fecha = dato;
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListaAmigos = BD.ListarAmigos();
            return View();
        }
    }
}