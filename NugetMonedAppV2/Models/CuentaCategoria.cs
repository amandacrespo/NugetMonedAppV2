using System.ComponentModel.DataAnnotations.Schema;

namespace NugetMonedAppV2.Models
{
    [Table("CuentasCategorias")]
    public class CuentaCategoria
    {
        [Column(Order = 0)]
        [ForeignKey("Cuenta")]
        public int IdCuenta { get; set; }

        [Column(Order = 1)]
        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }

        [ForeignKey("UsuarioAsignador")]
        public int? IdUsuarioAsignador { get; set; }

        [Column("FechaAsignacion")]
        public DateTime FechaAsignacion { get; set; }

        // Relaciones de navegación
        public Cuenta Cuenta { get; set; }
        public Categoria Categoria { get; set; }
        public Usuario UsuarioAsignador { get; set; }
    }

}
