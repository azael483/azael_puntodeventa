public class Descuento 
{
    public Producto Producto { get; set; }

    public decimal CalcularDescuento()
    {
        decimal descuento = 0;
        foreach (DetalleVenta dv in DetallesVenta)
        {
            descuento += dv.Subtotal *(Producto.PorcentajeDescuento / 100);
        }
        return descuento;
    }
}