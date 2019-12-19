using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda3.Models
{
    public class AmigosXEvento
    {

        private string _Nombre;
        private int _IdAmigo;
        private int _IdEvento;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int IdAmigo { get => _IdAmigo; set => _IdAmigo = value; }
        public int IdEvento { get => _IdEvento; set => _IdEvento = value; }

        public AmigosXEvento()
        {

        }
        public AmigosXEvento (string Nombre, int IdAmigo, int IdEvento)
        {
            _Nombre = Nombre;
            _IdAmigo = IdAmigo;
            _IdEvento = IdEvento;
        }
    }
}