namespace NugetMonedAppV2.Models
{
    public class CategoriaConCuenta
    {
        public int? IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public int? IdUsuarioCreador { get; set; }
        public int IdCuenta { get; set; }
        public string? NombreCuenta { get; set; }
        public string? TipoCuenta { get; set; }
    }
}
