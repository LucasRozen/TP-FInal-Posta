﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agenda3.Models;

namespace Agenda3.Controllers
{
    public class BackOfficeController : Controller
    {       
        void listaramigos()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListaAmigos = BD.ListarAmigos();
        }     
        public ActionResult Index()
        {
            listaramigos();
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
            listaramigos();
            return View();
        }
        public ActionResult TiposEve()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos=BD.ListarTipoEve();
            return View();
        }
        public ActionResult AgregarAmigo()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            return View();
        }
        public ActionResult InsertarAmigo(Amigos ami)
        {
            BD.AgregarAmigo(ami.Nombre, ami.Activo); 
            return RedirectToAction("Amigos", "Home");
        }
        public ActionResult EliminarAmigo(int id)
        {
            BD.EliminarAmigo(id);
            return RedirectToAction("Amigos", "Home");
        }
        public ActionResult EditarAmigo(Amigos ami, int id)
        {
            BD.EditarAmigo(ami.Nombre,id);
            return RedirectToAction("Amigos", "Home");
        }
        public ActionResult EditoAmigo()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            return View();
        }
        public ActionResult AgregarEvento()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            return View();
        }
        public ActionResult InsertarEvento(Amigos ami)
        {
            BD.AgregarAmigo(ami.Nombre, ami.Activo);
            return RedirectToAction("Amigos", "Home");
        }
        public ActionResult EliminarEvento(int id)
        {
            BD.EliminarAmigo(id);
            return RedirectToAction("Amigos", "Home");
        }
        public ActionResult EditarEvento(Amigos ami, int id)
        {
            BD.EditarAmigo(ami.Nombre, id);
            return RedirectToAction("Amigos", "Home");
        }
        public ActionResult EditoEvento()
        {
            ViewBag.ListarEve = BD.ListarTipoEve();
            ViewBag.ListarTipos = BD.ListarTipoEve();
            return View();
        }



    }
}