namespace NugetMonedAppV2.DTOs
{
    public class DashboardInfoDTO
    {
        public int IdCuenta { get; set; }
        public string NombreCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public decimal MontoInicial { get; set; }
        public decimal MontoActual { get; set; }
        public decimal BalanceAcumulado { get; set; }
        public decimal BalanceMensual { get; set; }
        public List<TransaccionDTO> UltimasTransacciones { get; set; }
    }
}
