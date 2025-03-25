using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetMonedAppV2.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [Column("IdUsuario")]
        public int IdUsuario { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Dni")]
        public string Dni { get; set; }

        [Column("CorreoElectronico")]
        public string CorreoElectronico { get; set; }

        [Column("ClaveTexto")]
        public string ClaveTexto { get; set; }

        [Column("ClaveHash")]
        public byte[] ClaveHash { get; set; }

        [Column("ClaveSalt")]
        public string ClaveSalt { get; set; }

        [Column("Estado")]
        public string Estado { get; set; }

        [Column("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }
    }
}
