using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Tortugero
    {
        List<Tortuga> tortugas;
        public Tortugero()
        {
            tortugas = new List<Tortuga>();
        }

        public void addTortuga(Tortuga tortuga)
        {
            tortugas.Add(tortuga);
        }

        public void removeTortuga(Tortuga tortuga)
        {
            tortugas.Remove(tortuga);
        }
    }
}