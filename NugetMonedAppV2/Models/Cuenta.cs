using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NugetMonedAppV2.Models
{
    [Table("Cuentas")]
    public class Cuenta
    {
        [Key]
        [Column("IdCuenta")]
        public int IdCuenta { get; set; }

        [Column("NombreCuenta")]
        public string NombreCuenta { get; set; }

        [Column("Descripcion")]
        public string Descripcion { get; set; }

        [Column("TipoCuenta")]
        public string TipoCuenta { get; set; }

        [Column("Moneda")]
        public string Moneda { get; set; }

        [Column("SaldoInicial")]
        public decimal SaldoInicial { get; set; }

        [Column("SaldoActual")]
        public decimal SaldoActual { get; set; }

        [Column("Estado")]
        public string Estado { get; set; }

        [Column("FechaCreacion")]
        public DateTime FechaCreacion { get; set; }
        public CuentaCategoria CuentasCategorias { get; internal set; }
    }
}
