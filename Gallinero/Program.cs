using System;
using System.Collections.Generic;

class Gallina
{
    private readonly IHuevoFactory _huevoFactory;
    public List<Huevo> huevos { get; }

    public Gallina(IHuevoFactory huevoFactory)
    {
        _huevoFactory = huevoFactory;
        huevos = new List<Huevo>();
    }

    public void PonerHuevo()
    {
        Huevo huevo = _huevoFactory.CrearHuevo(this);
        huevos.Add(huevo);
    }

    public void HuevosPuestos()
    {
        Console.WriteLine("La gallina ha puesto " + huevos.Count + " huevo(s).");
    }
}

interface IHuevoFactory
{
    Huevo CrearHuevo(Gallina gallina);
}

class Huevo
{
    private readonly Gallina _gallina;

    public Huevo(Gallina gallina)
    {
        _gallina = gallina;
    }

    public Gallina ObtenerGallina()
    {
        return _gallina;
    }
}

class HuevoFactory : IHuevoFactory
{
    public Huevo CrearHuevo(Gallina gallina)
    {
        return new Huevo(gallina);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IHuevoFactory huevoFactory = new HuevoFactory();
        Gallina gallina = new Gallina(huevoFactory);
        gallina.PonerHuevo();
        gallina.PonerHuevo();
        gallina.HuevosPuestos();

        Console.ReadLine();
    }
}
