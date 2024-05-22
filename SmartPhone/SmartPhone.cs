using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartPhone
{
    public class SmartPhone : IMostrable
    {
        private string modelo;
        private Bateria bateria;  // Composición
        private int nroChips;
        private Chip[] chips;     // Agregacion

        public SmartPhone(string modelo, int canMAh, string marcaBateria)
        {
            this.modelo = modelo;
            this.bateria = new Bateria(canMAh, marcaBateria);
            this.nroChips = 0;
            this.chips = new Chip[2];

        }

        public void mostrar()
        {
            Console.WriteLine("Modelo: " + modelo);
            bateria.mostrar();
            Console.WriteLine("Nº Chips: " + nroChips);
            for (int i = 0; i < nroChips; i++)
            {
                chips[i].mostrar();
            }
        }

        public void agregarChip(Chip nuevoChip)
        {
            if (nroChips < 2)
            {
                chips[nroChips] = nuevoChip;
                nroChips++;
            }

        }
    }
}