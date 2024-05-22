public class CarritoDeCompras
{
    public int IdCarrito { get; set; }
    public List<Producto> Productos { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Impuestos { get; set; }
    public Usuario Usuario { get; set; }
}
