using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    [Table("tbSolicitudAnalisis")]
    public class SolicitudAnalisis
    {
        public int IdSolicitud { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoExamen{ get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}
