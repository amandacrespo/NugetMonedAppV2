namespace NugetMonedAppV2.DTOs
{
    public class CategoriaDTO
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public int? IdUsuarioCreador { get; set; }
    }
}
