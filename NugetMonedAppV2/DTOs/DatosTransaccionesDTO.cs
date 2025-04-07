namespace NugetMonedAppV2.DTOs
{
    public class DatosTransaccionesDTO
    {
        public List<TransaccionDTO> Transacciones { get; set; }
        public List<CategoriaDTO> Categorias { get; set; }
        public List<CuentasAdminDTO> Cuentas { get; set; }
        public int CuentaSeleccionada { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
