public class Comentario
{
    public int IdComentario { get; set; }
    public Producto Producto { get; set; }
    public Usuario Usuario { get; set; }
    public string Contenido { get; set; }
    public DateTime Fecha { get; set; }
}
