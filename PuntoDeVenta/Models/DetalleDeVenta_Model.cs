public class DetalleVenta : Producto
{
    public int Id { get; set; }
    public Producto Producto { get;  set; }
    public int Cantidad { get; set; } 
    public decimal Subtotal { get; set; }
    public decimal impuesto { get;  set; }
    public decimal DescuentoPorcentaje { get; set; }
    public decimal DescuentoPesos { get; set; }


    public decimal CalcularDescuento()
    {
        DescuentoPesos += Producto.Precio *(DescuentoPorcentaje / 100);
        return DescuentoPesos;
    }

    public decimal CalcularSubtotal(DetalleVenta dv)
    {
        Impuesto impuesto = new Impuesto();
        dv.Subtotal = (Producto.Precio - dv.DescuentoPesos + impuesto.ImpuestoPesos)*Cantidad;
        return dv.Subtotal;
    }
}