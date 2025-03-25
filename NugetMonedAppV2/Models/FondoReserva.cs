using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NugetMonedAppV2.Models
{
    [Table("FondosReserva")]
    public class FondoReserva
    {
        [Key]
        [Column("IdFondo")]
        public int IdFondo { get; set; }

        [ForeignKey("Cuenta")]
        [Column("IdCuenta")]
        public int IdCuenta { get; set; }

        [ForeignKey("UsuarioCreador")]
        [Column("IdUsuarioCreador")]
        public int? IdUsuarioCreador { get; set; }

        [Column("CategoriaFondo")]
        public string CategoriaFondo { get; set; }

        [Column("MontoObjetivo")]
        public decimal MontoObjetivo { get; set; }

        [Column("MontoGastado")]
        public decimal MontoGastado { get; set; }

        [Column("FechaCreacion")]
        public DateTime FechaCreacion { get; set; }

        [Column("FechaObjetivo")]
        public DateTime? FechaObjetivo { get; set; }

        [Column("UltimaActualizacion")]
        public DateTime UltimaActualizacion { get; set; }

        [Column("EstadoFondo")]
        public string EstadoFondo { get; set; }

        [Column("Descripcion")]
        public string Descripcion { get; set; }

        // Relaciones de navegación
        public Cuenta Cuenta { get; set; }
        public Usuario UsuarioCreador { get; set; }
    }

}
