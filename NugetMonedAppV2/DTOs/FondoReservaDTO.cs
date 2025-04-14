using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMonedAppV2.DTOs
{
    public class FondoReservaDTO
    {
        public int IdFondo { get; set; }
        public string CategoriaFondo { get; set; }
        public decimal MontoObjetivo { get; set; }
        public decimal MontoGastado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaObjetivo { get; set; }
        public string EstadoFondo { get; set; }
        public string Descripcion { get; set; }
    }
}
