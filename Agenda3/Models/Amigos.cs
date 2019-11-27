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
        private bool _Activo;

        public int IdAmigo { get => _IdAmigo; set => _IdAmigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }

        public Amigos()
        {
        
        }

        public Amigos(int IdAmigo, string Nombre,bool Activo)
        {
            _IdAmigo = IdAmigo;
            _Nombre = Nombre;
            _Activo = Activo;
        }

    }
}
