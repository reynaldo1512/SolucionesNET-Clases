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
        
        public int IdCliente { get; set; }

        [Required]
        [StringLength(8)]
        [Column(TypeName = "nvarchar")]
        public string DNI { get; set; }

        [StringLength(50)]
        [Column(TypeName ="nvarchar")]
        [Required]
        public string  NombreCliente{ get; set; }

        [StringLength(80)]
        [Column(TypeName = "nvarchar")]
        [Required]
        public string ApellidosCliente{ get; set; }
        [StringLength(9)]
        [Column(TypeName = "nvarchar")]
        [Required]
        public string  Telefono { get; set; }

        [StringLength(80)]
        [Column(TypeName = "nvarchar")]
        
        public string Direccion  { get; set; }
        [StringLength(1)]
        [Column(TypeName = "nvarchar")]
       
        public string Sexo  { get; set; }
        
        [Column(TypeName = "datetime")]
        [Required]
        public DateTime FechaNacimiento  { get; set; }
        

    }
}
    