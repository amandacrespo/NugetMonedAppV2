namespace NugetMonedAppV2.DTOs
{
    public class CuentaDTO
    {
        public int IdCuenta { get; set; }
        public string NombreCuenta { get; set; }
        public string Descripcion { get; set; }
        public string Moneda { get; set; }
        public string TipoCuenta { get; set; }  // "Personal" o "Compartida"
        public bool Activa { get; set; } 
        public List<MiembroDTO> Miembros { get; set; }  // Lista de miembros (solo si es compartida)

        public CuentaDTO() {
            Miembros = new List<MiembroDTO>();
        }
    }
}
