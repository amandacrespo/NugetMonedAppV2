using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMonedAppV2.DTOs
{
    public class ActualizarSubcategoriaFondoDTO
    {
        public int IdSubcategoria { get; set; }
        public string NombreSubcategoria { get; set; }
        public int MontoAsignado { get; set; }
        public int MontoUtilizado { get; set; }
    }
}
