using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Nutria : Animal
    {
        private int _bigotes;

        public Nutria(string nombre, int edad) : base(nombre, edad)
        {
        }

        public void comen(IComida comida)
        {
            Console.WriteLine("Comiendo " + comida.AporteCalorico() + " kcal");
        }
    }
}