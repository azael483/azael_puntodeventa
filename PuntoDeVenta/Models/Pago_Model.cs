public class Pago
{
    public enum FormaPago
    {
        Efectivo,
        TarjetaCredito,
        TarjetaDebito,
        TransferenciaBancaria,
        Paypal
    }

    public int Id { get; set; }
    public decimal Monto { get; set; }
    public DateTime Fecha { get; set; }
    public FormaPago FormaPago { get; set; }
}