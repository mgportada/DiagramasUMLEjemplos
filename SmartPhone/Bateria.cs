using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartPhone
{
    public class Bateria : IMostrable
    {
        private int mAh;
        private string marca;

        public Bateria(int mAh, string marca)
        {
            this.mAh = mAh;
            this.marca = marca;
        }

        public void mostrar()
        {
            Console.WriteLine("\tCantidad mAh: " + mAh);
            Console.WriteLine("\tMarca: " + marca);
        }
    }
}