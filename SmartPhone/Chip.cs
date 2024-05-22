using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartPhone
{
    public class Chip : IMostrable
    {
        private string empresa;
        private int numero;

        public Chip(string empresa, int numero)
        {
            this.empresa = empresa;
            this.numero = numero;
        }

        public void mostrar()
        {
            Console.WriteLine("\tEmpresa: " + empresa);
            Console.WriteLine("\tNº cel:" + numero);
        }
    }
}