public class Venta
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public Cliente Cliente { get; set; }
    public List<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();
    public decimal Total { get; set; }
    public Pago Pago { get; set; }
}