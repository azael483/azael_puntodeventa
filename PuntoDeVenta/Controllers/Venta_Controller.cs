public class VentaControlador
{
    private List<Producto> carrito = new List<Producto>();

    public void AgregarProducto(Producto producto)
    {
        carrito.Add(producto);
    }

    public void ProcesarVenta()
    {
        decimal total = 0;
        foreach (var producto in carrito)
        {
            Console.WriteLine("esto buscamos: ", producto);
            //total += producto.Precio * producto.DetalleVenta.Cantidad;
        }

        Console.WriteLine("------- Resumen de la Venta -------");
        foreach (var producto in carrito)
        {
            //Console.WriteLine($"{producto.Nombre} - Cantidad: {producto.DetalleDeVenta.Cantidad} - Precio Unitario: {producto.Precio} - Subtotal: {producto.Precio * producto.Cantidad}");
        }
        Console.WriteLine($"Total a pagar: {total}");
    }
}