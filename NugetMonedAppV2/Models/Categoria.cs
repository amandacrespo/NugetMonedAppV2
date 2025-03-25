using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NugetMonedAppV2.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        [Column("IdCategoria")]
        public int IdCategoria { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Tipo")]
        public string Tipo { get; set; } // 'I' = Ingreso, 'G' = Gasto

        [Column("Descripcion")]
        public string Descripcion { get; set; }

        [Column("IdUsuarioCreador")]
        public int? IdUsuarioCreador { get; set; }

        [ForeignKey("IdUsuarioCreador")]
        public Usuario UsuarioCreador { get; set; }
    }
}
