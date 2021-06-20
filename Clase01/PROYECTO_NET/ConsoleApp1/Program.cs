using ConsoleApp1.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lista con datos
            /*
             int numero =0;

             List<int> listaNum = new List<int>();
             do
             {
                 Console.WriteLine("Ingrese numero : ");
                 numero = Convert.ToInt32(Console.ReadLine());
                 listaNum.Add(numero);
             } while (numero!= 0);

             Console.WriteLine("Listado : "); 


             foreach (var item in listaNum)
             {
                 Console.WriteLine(item);
             }




             Console.ReadLine(); */
            #endregion

            #region Lista con clases
            /*ClienteBEAN cliBEAN = new ClienteBEAN();
            cliBEAN.Nombre = "Reynaldo";
            cliBEAN.Apellido = "Vasquez" ;
            ClienteBEAN cliBEAN2 = new ClienteBEAN() { Nombre = "Juan", Apellido = "Perez" };

            List<ClienteBEAN> listaCliente = new List<ClienteBEAN>();
            listaCliente.Add(cliBEAN);
            listaCliente.Add(cliBEAN2);
            listaCliente.Add(new ClienteBEAN { Nombre = "Pedro", Apellido = "Juez" });
            foreach (var item in listaCliente)
            {
                Console.WriteLine(item.Nombre+ " " + item.Apellido);
            }
            */
            #endregion

            #region Diccionary-diccionario de datos 
            //key-value
            /* Dictionary<int, string> datos = new Dictionary<int, string>();
             datos.Add(1, "Lunes");
             datos.Add(2, "Martes");
             datos.Add(3, "Miercoles");
             datos.Add(4, "Jueves"); 
             datos.Add(5, "Viernes");
             datos.Add(6, "Sabado");
             datos.Add(7, "Domingo");
             /*que se ingrese los valores entre el 1 al 7 y que se muestre el dia de la semana */

            /* Console.WriteLine("Ingrese el valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El nombre del dia es :" + datos[valor]);
            Console.ReadLine(); */


            #endregion

            #region Ejercicio



            TrabajadorBEAN trabBEAN = new TrabajadorBEAN();
            List<TrabajadorBEAN> listaTrabajador = new List<TrabajadorBEAN>();

            Console.WriteLine("Ingrese su codigo");
            trabBEAN.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre");
            trabBEAN.Nombre =Console.ReadLine();



            Dictionary<int, int> ListaCostoExtra = new Dictionary<int, int>();
            ListaCostoExtra.Add(0, 10);
            ListaCostoExtra.Add(1, 12);
            ListaCostoExtra.Add(2, 12);
            ListaCostoExtra.Add(3, 12);
            ListaCostoExtra.Add(4, 13);
            ListaCostoExtra.Add(5, 13);
            ListaCostoExtra.Add(6, 15);
            ListaCostoExtra.Add(7, 15);
            ListaCostoExtra.Add(8, 15);

            Console.WriteLine("ingrese horas trabajadas : ");
            int horas = Convert.ToInt32(Console.ReadLine());
            trabBEAN.HorasTrabajo = horas;
            int horaExtra = 0;
            int costoHoraExtra = 0;
            int costoDia = 0;
            if (horas > 8)
            {
                horaExtra = horas - 8;
                costoHoraExtra = ListaCostoExtra[horaExtra] * horaExtra;
                costoDia = 8 * ListaCostoExtra[0];

            }
            else
            {
                costoDia = horas * ListaCostoExtra[0];
            }
            int PagoTotal = costoDia + costoHoraExtra;
            trabBEAN.PagoTotal=PagoTotal;

           /* Console.WriteLine("horas trabajadas: " + horas);
            Console.WriteLine("costo horas normales : " + costoDia + "S/.");
            Console.WriteLine("Horas extras : " + horaExtra + "S/.");
            Console.WriteLine("Costo de Horas Extra : " + costoHoraExtra + "S/.");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Pago a realizar : "+(costoDia+costoHoraExtra)+ "S/.");
            Console.ReadLine();*/

            listaTrabajador.Add(trabBEAN);
            foreach (var item in listaTrabajador)
            {
                Console.WriteLine(item.Codigo+ "\t" + item.Nombre + "\t" + item.HorasTrabajo + "\t" + item.PagoTotal);
            }

            Console.ReadLine();
        }

        













            #endregion
            /*
            //  = asignacion
            //  == comparacion
            ClienteBEAN cliBEAN = new ClienteBEAN();
            cliBEAN.Nombre = "Reynaldo";
            cliBEAN.Apellido = "Vasquez";
            cliBEAN.Edad = 22;
            cliBEAN.Genero = "M";
            cliBEAN.Carrera = "Ing. de Sistemas ";
            // Console.WriteLine("nombre: " + cliBEAN.Nombre +  " Apellido:" + cliBEAN.Apellido + " Genero: " + cliBEAN.Genero);


            ClienteBEAN cliBEAN2 = new ClienteBEAN();
            cliBEAN2.Nombre = "Juan ";
            cliBEAN2.Apellido = "Perez";
            //Console.WriteLine("nombre: "+cliBEAN2.Nombre + " " + "Apellido: " + cliBEAN2.Apellido);
            Console.WriteLine(cliBEAN.ConcatenarDatos());
            Console.WriteLine(cliBEAN2.ConcatenarDatos());
            Console.WriteLine(cliBEAN.ConcatenarDatosParametro("nombre 3", "apellido 3"));
           

            //POO 
            #region LISTAS CON UN TIPO DE DATOS 
            /*  lISTAS -LIST
             DICCIONARIO-DICTIONARY
            COLAS-QUEUE
            PILAS-STACK 
            */
            /*
                 List<int> listaNumeros = new List<int>();
                 listaNumeros.Add(40); //indice0
                 listaNumeros.Add(9); //indice1
                 listaNumeros.Add(10); //indice2
                 for (int i = 0; i < listaNumeros.Count; i++)
                 {
                     Console.WriteLine(listaNumeros[i]);
                 }

                 #endregion
                 Console.ReadLine(); */






        }
    }

