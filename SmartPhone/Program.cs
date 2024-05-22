using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartPhone
{
    public class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartphone = new SmartPhone("iPhone", 3000, "Apple");
            Chip chip1 = new Chip("Apple", 45234);
            smartphone.agregarChip(chip1);
            smartphone.mostrar();

        }
    }
}