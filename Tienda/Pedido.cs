using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tienda
{
    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }

        public Pedido(int numeroPedido, string descripcion, decimal monto)
        {
            NumeroPedido = numeroPedido;
            Descripcion = descripcion;
            Monto = monto;
        }
    }
}