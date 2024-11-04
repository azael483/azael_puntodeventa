public class DetalleVenta
{
    public int Id { get; set; }
    public Producto Producto { get; set; }
    public int Cantidad { get; set; } 
    public decimal Subtotal { get; set; }
    public Impuesto impuesto { get; set; }
    public Descuento descuento { get; set; }


    public decimal CalcularSubtotal()
    {
        
        subtotal += (Producto.Precio - Descuento.descuento + Impuesto.impuesto)*Cantidad;
        return subtotal;
    }
}