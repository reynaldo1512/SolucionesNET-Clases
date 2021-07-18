using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_ADO.modelo;

namespace EF_ADO.DAO
{
   public class TarjetaDAO
    {


        public void ListaTarjeta()
        {
            Console.Clear();
            List<tbTarjeta> listatarjeta = new List<tbTarjeta>();
            using (var db = new BD_Practica1())
            {
                listatarjeta = db.tbTarjeta.ToList();

            }
            Console.WriteLine("LISTA DE TARJETA");
            Console.WriteLine("idTarjeta" + "     " + "numtarjeta" + "            "+"Tip tarjeta  "+"           " + "modpago"+
            "           "+"fecha ven" +"              " +"idcliente");
            foreach (var item in listatarjeta)
            {
                Console.WriteLine(item.idTarjeta+ "         " + item.numeroTarjeta + "                " + item.tipoTarjeta+"            "+
                    item.modoPago+"                "+ item.fechaVencimiento+"                    "+item.idCliente);
            }
            Console.ReadLine();
        }
        public void RegistrarTarjeta()
        {
            Console.Clear();

            
            Console.WriteLine("Ingrese numero  de la tarjeta ");
            string numtarjeta = Console.ReadLine();
            Console.WriteLine("Ingrese tipo de tarjeta");
            string tipotarjeta = Console.ReadLine();
            Console.WriteLine("Ingrese modo de pago");
            string modopago = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de vencimiento");
            string fechavenci = Console.ReadLine();

            Console.WriteLine("Ingrese el id del cliente");
            int idcliente = Convert.ToInt32(Console.ReadLine());


            tbTarjeta tarjeta = new tbTarjeta { numeroTarjeta = numtarjeta, tipoTarjeta = tipotarjeta, modoPago = modopago, fechaVencimiento = fechavenci,idCliente=idcliente};

            using (var db = new BD_Practica1())
            {
                db.tbTarjeta.Add(tarjeta);
                db.SaveChanges();
            }
            Console.WriteLine("se registro corrrectamente");
            Console.ReadLine();

        }


        public void ActualizarTarjeta()
        {
            Console.Clear();
            Console.WriteLine("ingrese el Id de la tarjeta a editar : ");
            int idtarjeta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese el nuevo numero de tarjeta ");
            string numtarjeta = Console.ReadLine();
            using (var db = new BD_Practica1())
            {
                tbTarjeta tarjeta= db.tbTarjeta.Find(idtarjeta);
                tarjeta.numeroTarjeta = numtarjeta;
                db.SaveChanges();

                Console.WriteLine("El pais con codigo :" + idtarjeta+ " se actualizo de manera correcta");
            }




        }
    }
}
