using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda3.Models
{
    public class Evento
    {
        private int _IdEve;
        private string _Nombre;
        private int _idTipEve;
        private int _idAmigo;
        private DateTime Dia;
        private string Descipcion;
        private bool Activo;
        private bool Destac;
        public int IdEve { get => _IdEve; set => _IdEve = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int IdTipEve { get => _idTipEve; set => _idTipEve = value; }
        public int IdAmigo { get => _idAmigo; set => _idAmigo = value; }
        public DateTime Dia { get => Dia; set => Dia = value; }
        public string Descipcion { get => Descipcion; set => Descipcion = value; }
        public bool Activo { get => Activo; set => Activo = value; }
        public bool Destac { get => Destac; set => Destac = value; }

        public Evento(int IdEve, string nom,int IdTEve, int IdAmi, DateTime dia, string descr, bool Act, bool destac)
        {
            IdEve = _IdEve;
            nom = _Nombre;
            IdTEve = _idTipEve;
            IdAmi = _idAmigo;
            dia = Dia;
            descr = Descipcion;
            Act = Activo;
            destac = Destac;
        }
           

        public Evento()
        {

        }

        
    }
}