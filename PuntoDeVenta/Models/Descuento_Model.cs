public class Impuesto
{
    public Producto Producto { get; set; }

    public decimal CalcularDescuento()
    {
        decimal impuesto = 0;
        foreach (DetalleVenta dv in DetallesVenta)
        {
            impuesto += dv.Subtotal *(Producto.PorcentajeImpuesto / 100);
        }
        return impuesto;
    }
}