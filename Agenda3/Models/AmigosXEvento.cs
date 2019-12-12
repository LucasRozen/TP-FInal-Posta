using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda3.Models
{
    public class AmigosXEvento
    {

        private string _Nombre;

        public string Nombre { get => _Nombre; set => _Nombre = value; }

        public AmigosXEvento()
        {

        }
        public AmigosXEvento (string Nombre)
        {
            _Nombre = Nombre;
        }
    }
}