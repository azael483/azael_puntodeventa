public class Inventario
{
    public Producto Producto { get; set; }
    public List<Producto> Productos { get; set; } = new List<Producto>();

    public void AgregarProducto(Producto producto)
    {
        Productos.Add(producto);
    }

    public void EliminarProducto(int idProducto)
    {
        if (Productos != null)
        {
            for (int i = Productos.Count - 1; i >= 0; i--)
            {
                if (Productos[i].Id == idProducto)
                {
                    Productos.RemoveAt(i);
                    return;
                }
            }
        }
        Console.WriteLine("Producto no encontrado");
    }

    public void ActualizarStock(int idProducto, int nuevaCantidad)
    {
        foreach (var producto in Productos)
        {
            if (producto.Id == idProducto)
            {
                producto.Stock = nuevaCantidad;
                return;
            }
        }
        Console.WriteLine("Producto no encontrado");
    }

    public List<Producto> BuscarProductosPorNombre(string nombre)
    {
        List<Producto> productosFiltrados = new List<Producto>();
        foreach (Producto producto in Productos)
        {
            if (producto.Nombre.Contains(nombre))
            {
                productosFiltrados.Add(producto);
            }
        }
        return productosFiltrados;
    }
}