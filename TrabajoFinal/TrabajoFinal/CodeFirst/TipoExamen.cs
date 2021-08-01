using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    [Table("tbTipoExamen")]
    public class TipoExamen
    {
        [Key]
        [Required]
        public int IdTipoExamen { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName ="nvarchar")]
        public string NombreExamen { get; set; }
        

        [Required]
        public double precio  { get; set; }

        public List<SolicitudAnalisis> solicitudAnalises { get; set; }


    }
}
