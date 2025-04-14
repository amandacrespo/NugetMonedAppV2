using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMonedAppV2.DTOs
{
    public class CrearFondoDTO
    {
        public int IdCuenta { get; set; }
        public string CategoriaFondo { get; set; }
        public int MontoObjetivo { get; set; }
        public DateTime FechaObjetivo { get; set; }
        public string Descripcion { get; set; }
    }
}
