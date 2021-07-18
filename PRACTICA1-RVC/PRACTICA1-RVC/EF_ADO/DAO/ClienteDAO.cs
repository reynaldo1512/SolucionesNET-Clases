using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EF_ADO.modelo;

namespace EF_ADO.DAO
{
    public class ClienteDAO
    {
        public void ListaCliente()
        {
            Console.Clear();
            List<tbCliente> listacliente = new List<tbCliente>();
            using (var db=  new BD_Practica1())
            {
                listacliente = db.tbCliente.ToList();

            }
            Console.WriteLine("LISTA DE CLIENTES");
            Console.WriteLine("idCLiente" + "     " + "nombre" + "     " + "apellido"+ "     " + " fecha de nacimiento"+ "        " + "dni");
            foreach (var item in listacliente)
            {
                Console.WriteLine(item.idCliente+ "      "+ item.nombreCliente + "              "+item.apellidosCliente+"                      "+item.fechaNacimiento+
                    "              "+ item.dniCliente);
            }
            Console.ReadLine();
        }

        public void RegistrarCliente()
        {
            Console.Clear();

            Console.WriteLine("Ingrese nombre del cliente");
            string nombreCli = Console.ReadLine();
            Console.WriteLine("Ingrese apellido del cliente");
            string apellidoCli = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento");
            DateTime fechaNac = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese dni del cliente");
            string dni = Console.ReadLine();

            tbCliente cli = new tbCliente { nombreCliente = nombreCli, apellidosCliente = apellidoCli, fechaNacimiento = fechaNac, dniCliente = dni };

            using (var db = new BD_Practica1())
            {
                db.tbCliente.Add(cli);
                db.SaveChanges();
            }
            Console.WriteLine("se registro corrrectamente");
            Console.ReadLine();

            

        }

        public void ActualizarCliente()
        {
            Console.Clear();
            Console.WriteLine("ingrese el Id de Cliente a editar : ");
            int idCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese el nuevo nombre ");
            string nombreCli = Console.ReadLine();
            using (var db = new BD_Practica1())
            {
                tbCliente cli = db.tbCliente.Find(idCliente);
                cli.nombreCliente = nombreCli;
                db.SaveChanges();

                Console.WriteLine("El cliente con codigo :"+ idCliente + " se actualizo de manera correcta");
            }



            
        }


    }
}
