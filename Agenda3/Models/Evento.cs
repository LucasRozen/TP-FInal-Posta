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
        private DateTime _Dia;
        private string _Descipcion;
        private bool _Activo;
        private bool _Destac;
        public int IdEve { get => _IdEve; set => _IdEve = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int IdTipEve { get => _idTipEve; set => _idTipEve = value; }
        public int IdAmigo { get => _idAmigo; set => _idAmigo = value; }
        public DateTime Dia { get => _Dia; set => _Dia = value; }
        public string Descipcion { get => _Descipcion; set => _Descipcion = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }
        public bool Destac { get => _Destac; set => _Destac = value; }


        public Evento()
        {

        }


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
           

       

        
    }
}