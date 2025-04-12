namespace NugetMonedAppV2.DTOs
{
    public class CuentaNuevaDTO
    {
        public string NombreCuenta { get; set; }
        public string Descripcion { get; set; }
        public string TipoCuenta { get; set; }
        public string Moneda { get; set; }
        public decimal SaldoInicial { get; set; }
        public int IdUsuarioCreador { get; set; }
    }
}
