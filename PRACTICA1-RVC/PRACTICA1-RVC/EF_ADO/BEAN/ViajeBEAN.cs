using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ADO.BEAN
{
    public class ViajeBEAN
    {
        public int IdViaje { get; set; }
        public int IdTarjeta { get; set; }
        public int IdPais { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string EstadoViaje { get; set; }
    }
}
