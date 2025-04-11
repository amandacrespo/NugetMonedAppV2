namespace NugetMonedAppV2.DTOs
{
    public class CrearTransaccionDTO
    {
        public int IdCuenta { get; set; }
        public int IdCategoria { get; set; }
        public decimal Monto { get; set; }
        public char Tipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
