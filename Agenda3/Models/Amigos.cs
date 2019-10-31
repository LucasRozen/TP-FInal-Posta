using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda3.Models
{
    public class Amigos
    {
        private int _IdAmigo;
        private string _Nombre;

        public int IdAmigo { get => _IdAmigo; set => _IdAmigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }

        public Amigos()
        {

        }

        public Amigos(int IdAmigo, string Nombre)
        {
            _IdAmigo = IdAmigo;
            _Nombre = Nombre;
        }

    }