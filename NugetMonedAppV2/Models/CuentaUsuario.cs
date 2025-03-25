using System.ComponentModel.DataAnnotations.Schema;

namespace NugetMonedAppV2.Models
{
    [Table("CuentasUsuarios")]
    public class CuentaUsuario
    {
        //[Key]
        [Column(Order = 0)]
        [ForeignKey("Cuenta")]
        public int IdCuenta { get; set; }

        //[Key]
        [Column(Order = 1)]
        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        [Column("Rol")]
        public string Rol { get; set; } // "Administrador" o "Miembro"

        [Column("Estado")]
        public string Estado { get; set; } // "Activo", "Inactivo", "Suspendido"

        [Column("FechaAsignacion")]
        public DateTime FechaAsignacion { get; set; }

        [Column("FechaUltimaModificacion")]
        public DateTime FechaUltimaModificacion { get; set; }

        // Relaciones de navegación
        public Cuenta Cuenta { get; set; }
        public Usuario Usuario { get; set; }
    }

}
