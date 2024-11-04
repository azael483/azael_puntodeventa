public class CarritoDeCompra
{
    public List<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (DetalleVenta dv in DetallesVenta)
        {
            total += dv.Subtotal;
        }
        return total;
    }
}