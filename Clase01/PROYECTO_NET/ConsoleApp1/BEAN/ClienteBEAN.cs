using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BEAN
{
    public class ClienteBEAN
    { //uso del prop
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        //propfull
        private string genero;

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Carrera { get; set; }

        /*Metodos*/
        public string ConcatenarDatos()
        {
            string concatenado = "";
            concatenado = Nombre + " " + Apellido;
            return concatenado;
        }


        public string ConcatenarDatosParametro(string nombre, string apellido)
        {
            string concatenado = "";
            concatenado = nombre + " " + apellido+ "" ;
            return concatenado;
        }

    }
}
