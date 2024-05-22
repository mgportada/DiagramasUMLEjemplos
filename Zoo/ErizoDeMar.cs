using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class ErizoDeMar : IComida
    {
        private int _kg;

        public ErizoDeMar(int kg)
        {
            this._kg = kg;
        }

        public int AporteCalorico()
        {
            return _kg * 10;
        }
    }
}