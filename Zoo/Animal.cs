using System;

namespace Zoo
{

    public abstract class Animal
    {


        public string nombre { get; }
        public int edad { get; }

        public int Id
        {
            get;
        }

        public void comen()
        {
            Console.WriteLine("Comiendo!");
        }

        public Animal(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}