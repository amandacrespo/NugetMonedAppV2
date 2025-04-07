namespace NugetMonedAppV2.DTOs
{
    public class TransaccionDTO
    {
        public int IdTransaccion { get; set; }
        public int IdCuenta { get; set; }
        public int IdCategoria { get; set; }
        public decimal Monto { get; set; }
        public char Tipo { get; set; }  // 'I' para ingresos, 'G' para gastos
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
