using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    [Table("tbPais")]
    public class Pais
    {


        [Key]
        [Required]
        public int idPais { get; set; }


        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        public string nombrePais { get; set; }

        [StringLength(10)]
        [Column(TypeName = "nvarchar")]
        public string codigoPais { get; set; }

        public  List<Viaje> Viajes { get; set; }

    }
}
