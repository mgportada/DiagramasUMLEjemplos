﻿public class Producto
{
    public int IdProducto { get; set; }
    public string Nombre { get; set; }
    public string Descripción { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public Categoria Categoria { get; set; }
}
