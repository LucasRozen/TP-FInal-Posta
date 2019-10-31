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

        public int IdTipEve { get => _idTipEve; set => _idTipEve = value; }
        public string TipEve { get => _TipEve; set => _TipEve = value; }


        public TiposEve()
        {
            
        }

        public TiposEve(int idTipEve, string TipEve)
        {
            _idTipEve = idTipEve;
            _TipEve = TipEve;
        }

        
    }

    

}