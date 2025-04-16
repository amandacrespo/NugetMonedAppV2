namespace NugetMonedAppV2.DTOs
{
    public class TransaccionesPorMesDTO
    {
        public int Mes { get; set; }  // 1 - 12
        public string Categoria { get; set; }  
        public char Tipo { get; set; }  // 'I' para ingreso, 'G' para gasto
        public decimal Total { get; set; }  // Monto total en ese mes y categoría
    }
}
