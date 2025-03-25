namespace NugetMonedAppV2.Models
{
    public class FondosDTO
    {
        public Cuenta Cuenta { get; set; } 
        public List<FondoReserva> FondosReserva { get; set; } = new();
        public List<SubcategoriaFondo> Subcategorias { get; set; } = new();

        // Totales calculados
        public decimal TotalObjetivo => FondosReserva
            .Where(f => f.EstadoFondo == "Activo")
            .Sum(f => f.MontoObjetivo);

        public decimal TotalGastado => FondosReserva
            .Where(f => f.EstadoFondo == "Activo") 
            .Sum(f => f.MontoGastado);

        public decimal PorcentajeGeneral => TotalObjetivo > 0 ? (TotalGastado / TotalObjetivo) * 100 : 0;
    }
}
