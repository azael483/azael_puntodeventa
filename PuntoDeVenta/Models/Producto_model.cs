public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public int PorcentajeDescuento { get; set; }
    public int PorcentajeImpuesto { get; set; }

}

var banana = new Producto
{
    Id = 456,
    Nombre = "Banana"
};