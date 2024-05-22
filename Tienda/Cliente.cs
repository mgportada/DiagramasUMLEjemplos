using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tienda
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        private List<Pedido> pedidos;

        public Cliente(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            pedidos = new List<Pedido>();
        }

        // Método para agregar un pedido al cliente (composición)
        public void AgregarPedido(int numeroPedido, string descripcion, decimal monto)
        {
            // Si el argumento fuera el pedido, sería una asociación de agregacion y no de asociación
            Pedido nuevoPedido = new Pedido(numeroPedido, descripcion, monto);
            pedidos.Add(nuevoPedido);
        }

        // Método para mostrar los pedidos del cliente
        public void MostrarPedidos()
        {
            Console.WriteLine($"Pedidos de {Nombre}:");
            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"Número de Pedido: {pedido.NumeroPedido}, Descripción: {pedido.Descripcion}, Monto: {pedido.Monto}");
            }
        }
    }
}