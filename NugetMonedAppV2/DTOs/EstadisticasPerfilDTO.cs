using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMonedAppV2.DTOs
{
    public class EstadisticasPerfilDTO
    {
        public int TotalCuentas { get; set; }
        public int CuentasActivas { get; set; }
        public int CuentasInactivas { get; set; }
        public int TotalFondos { get; set; }
        public decimal TotalMontoReservado { get; set; }
        public decimal TotalMontoGastado { get; set; }
        public int TotalTransacciones { get; set; }
        public decimal TotalIngresos { get; set; }
        public decimal TotalGastos { get; set; }
    }
}
