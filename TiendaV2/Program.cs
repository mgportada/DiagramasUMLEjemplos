using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso
        Usuario usuario = new Usuario
        {
            IdUsuario = 1,
            Nombre = "Juan Pérez",
            CorreoElectronico = "juan@example.com",
            Contraseña = "contraseña123",
            Dirección = "Calle 123, Ciudad",
            MétodoDePago = "Tarjeta de crédito"
        };

        Producto producto = new Producto
        {
            IdProducto = 1,
            Nombre = "Camiseta",
            Descripción = "Camiseta de algodón",
            Precio = 20.5m,
            Stock = 100,
            Categoria = new Categoria { IdCategoría = 1, Nombre = "Ropa" }
        };

        CarritoDeCompras carrito = new CarritoDeCompras
        {
            IdCarrito = 1,
            Productos = new List<Producto> { producto },
            Subtotal = 20.5m,
            Impuestos = 2.05m,
            Usuario = usuario
        };

        OrdenDeCompra orden = new OrdenDeCompra
        {
            IdOrden = 1,
            Productos = new List<Producto> { producto },
            Subtotal = 20.5m,
            Impuestos = 2.05m,
            Envío = 5.0m,
            Total = 27.55m,
            Usuario = usuario
        };

        Comentario comentario = new Comentario
        {
            IdComentario = 1,
            Producto = producto,
            Usuario = usuario,
            Contenido = "Me encanta esta camiseta!",
            Fecha = DateTime.Now
        };

        Console.WriteLine("Ejemplo de uso de las clases:");
        Console.WriteLine($"Usuario: {usuario.Nombre}");
        Console.WriteLine($"Producto: {producto.Nombre}");
        Console.WriteLine($"Carrito de Compras: Subtotal: {carrito.Subtotal}, Impuestos: {carrito.Impuestos}");
        Console.WriteLine($"Orden de Compra: Total: {orden.Total}");
        Console.WriteLine($"Comentario: {comentario.Contenido}");
    }
}
