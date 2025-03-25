using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NugetMonedAppV2.Models
{
    [Table("SubcategoriasFondos")]
    public class SubcategoriaFondo
    {
        [Key]
        [Column("IdSubcategoria")]
        public int IdSubcategoria { get; set; }

        [ForeignKey("FondoReserva")]
        [Column("IdFondo")]
        public int IdFondo { get; set; }

        [Column("NombreSubcategoria")]
        public string NombreSubcategoria { get; set; }

        [Column("MontoAsignado")]
        public decimal MontoAsignado { get; set; }

        [Column("MontoUtilizado")]
        public decimal MontoUtilizado { get; set; } 

        [Column("EstadoSubcategoria")]
        public string EstadoSubcategoria { get; set; }

        // Relaciones de navegación
        public FondoReserva FondoReserva { get; set; }
    }

}
