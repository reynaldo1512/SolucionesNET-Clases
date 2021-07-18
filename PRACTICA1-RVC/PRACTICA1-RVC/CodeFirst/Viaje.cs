using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    [Table("tbViaje")]
    public class Viaje
    {


        [Key]
        [Required]
        public int idViaje { get; set; }

        [Required]
        public int idTarjeta { get; set; }

        [Required]
        public int  idPais { get; set; }

        [Column(TypeName = "datetime")]
        public  DateTime fechaInicioViaje   { get; set; }


        [Column(TypeName = "datetime")]
        public DateTime fechaFinViaje { get; set; }

        [StringLength(1)]
        [Column(TypeName = "nvarchar")]
        public string estadoViaje { get; set; }



        public Tarjeta Tarjeta { get; set; }
        public Pais Pais { get; set; }





    }
}
