using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda3.Models
{
    public class TiposEve
    {

        private int _idTipEve;
        private string _TipEve;
        private bool _Activo;

        public int IdTipEve { get => _idTipEve; set => _idTipEve = value; }
        public string TipEve { get => _TipEve; set => _TipEve = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }

        public TiposEve()
        {
            
        }

        public TiposEve(int IdTipEve, string TipEve,bool Activo)
        {
            _idTipEve = IdTipEve;
            _TipEve = TipEve;
            _Activo = Activo;
        }

        
    }

    

}