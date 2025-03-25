using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NugetMonedAppV2.Models
{
    [Table("Transacciones")]
    public class Transaccion
    {
        [Key]
        [Column("IdTransaccion")]
        public int IdTransaccion { get; set; }

        [ForeignKey("Cuenta")]
        [Column("IdCuenta")]
        public int IdCuenta { get; set; }  

        [Column("IdCategoria")]
        public int IdCategoria { get; set; } 

        [Column("Monto")]
        public decimal Monto { get; set; }  

        [Column("Tipo")]
        public char Tipo { get; set; }  // Tipo de transacción ('I' = Ingreso, 'G' = Gasto)

        [Column("Fecha")]
        public DateTime Fecha { get; set; }  

        [Column("Descripcion")]
        public string Descripcion { get; set; } 

      
        public Cuenta Cuenta { get; set; }
        public Categoria Categoria { get; set; }
    }

}
