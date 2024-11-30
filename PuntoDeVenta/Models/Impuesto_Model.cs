public class Impuesto : Producto
{
    public Producto Producto { get; set; }
    public decimal ImpuestoPorcentaje { get; set; }
    public decimal ImpuestoPesos { get; set; }


    public decimal CalcularImpuesto()
    {
        ImpuestoPesos += Producto.Precio *(ImpuestoPorcentaje / 100);
        return ImpuestoPesos;
    }
}