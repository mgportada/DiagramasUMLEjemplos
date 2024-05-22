using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class CentroDeVisitantes
    {
        private List<Aseo> _aseos;
        private Recepcion _recepcion;

        public CentroDeVisitantes()
        {
            _aseos = new List<Aseo>();
            _recepcion = new Recepcion();
        }
        public void addAseo()
        {
            _aseos.Add(new Aseo());
        }
    }
}