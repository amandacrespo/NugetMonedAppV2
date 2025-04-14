using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMonedAppV2.DTOs
{
    public class CrearSubcategoriaFondoDTO
    {
        public int idFondo { get; set; }
        public string nombreSubcategoria { get; set; }
        public int montoAsignado { get; set; }
    }
}
