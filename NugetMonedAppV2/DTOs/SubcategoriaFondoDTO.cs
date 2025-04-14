using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMonedAppV2.DTOs
{
    public class SubcategoriaFondoDTO
    {
        public int IdSubcategoria { get; set; }
        public int IdFondo { get; set; }
        public string NombreSubcategoria { get; set; }
        public decimal MontoAsignado { get; set; }
        public decimal MontoUtilizado { get; set; }
        public string EstadoSubcategoria { get; set; }
    }
}
