using NugetMonedAppV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMonedAppV2.DTOs
{
    public class CategoriasUsuarioDTO
    {
        public List<CategoriaDTO> Predefinidas { get; set; }
        public List<CategoriaConCuentaDTO> Personalizadas { get; set; }
    }
}
