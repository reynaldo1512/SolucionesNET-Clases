using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbCliente")]
    public class Cliente
    {
       [Key]
        public int IdCliente { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName ="varchar")]
        public string NombreCliente { get; set; }
        public int IdTipoDoc { get; set; }

        public TipoDocumento tipoDocumento { get; set; }
    }
}
