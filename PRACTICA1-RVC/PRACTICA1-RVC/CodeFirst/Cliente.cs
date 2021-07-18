using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
   
    
        [Table("tbCliente")]
        public class Cliente
        {
            [Key]
            [Required]
            public int idCliente { get; set; }

            
            [StringLength(50)]
            [Column(TypeName = "nvarchar")]
            public string nombreCliente { get; set; }

             [StringLength(50)]
            [Column(TypeName = "nvarchar")]
            public string apellidoCliente { get; set; }

        
        [Column(TypeName = "datetime")]
        [Required]
        public  DateTime fechaNacimiento { get; set; }

        [StringLength(15)]
       
        [Column(TypeName = "nvarchar")]
        public string dniCliente { get; set; }


        public List<Tarjeta> Tarjetas { get; set; }

            
        }
    
}
