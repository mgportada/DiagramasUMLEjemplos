public class OrdenDeCompra
{
    public int IdOrden { get; set; }
    public List<Producto> Productos { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Impuestos { get; set; }
    public decimal Envío { get; set; }
    public decimal Total { get; set; }
    public Usuario Usuario { get; set; }
}
