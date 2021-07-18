using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ADO.BEAN
{
    public class ClienteBEAN
    {

        public int IdCliente { get; set; }
        public  string NombreCliente { get; set; }
        public string ApellidoCliente{ get; set; }
        public DateTime FechaNacimiento{ get; set; }
        public string DniCliente { get; set; }
    }
}
