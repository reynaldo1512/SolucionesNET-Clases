using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    [Table("tbTarjeta")]
   public  class Tarjeta
    {
        [Key]
        [Required]
        public int idTarjeta { get; set; }


        [StringLength(30)]
        [Column(TypeName = "nvarchar")]
        public string numeroTarjeta { get; set; }

        [StringLength(20)]
        [Column(TypeName = "nvarchar")]
        public string tipoTarjeta { get; set; }

        [StringLength(20)]
        [Column(TypeName = "nvarchar")]
        public string modoPago { get; set; }

        [StringLength(10)]
        [Column(TypeName = "nvarchar")]
        public string fechaVencimiento { get; set; }

        [Required]
        public int idCliente { get; set; }

        public Cliente Cliente { get; set; }

        public List<Viaje> Viajes { get; set; }
    }
}
