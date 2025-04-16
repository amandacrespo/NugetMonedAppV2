namespace NugetMonedAppV2.DTOs
{
    public class CuentaConMiembrosDTO
    {
        public int IdCuenta { get; set; }
        public string NombreCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public string Descripcion { get; set; }
        public string Moneda { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoActual { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<string> Miembros { get; set; }
        public string Rol { get; set; }
    }
}
