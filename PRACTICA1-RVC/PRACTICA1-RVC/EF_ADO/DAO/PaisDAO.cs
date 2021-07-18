using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_ADO.modelo;

namespace EF_ADO.DAO
{
    class PaisDAO
    {
        public void ListaPais()
        {
            Console.Clear();
            List<tbPais> listapais = new List<tbPais>();
            using (var db = new BD_Practica1())
            {
                listapais = db.tbPais.ToList();

            }
            Console.WriteLine("LISTA DE PAIS");
            Console.WriteLine("idPais" + "     " + "nombre" + "     " + "codigo");
            foreach (var item in listapais)
            {
                Console.WriteLine(item.idPais + "      " + item.nombrePais + "              " + item.codigoPais);
            }
            Console.ReadLine();
        }
        public void RegistrarPais()
        {
            Console.Clear();

            Console.WriteLine("Ingrese nombre del Pais");
            string nombrepais = Console.ReadLine();
            Console.WriteLine("Ingrese codigo del Pais");
            string codpais= Console.ReadLine();
            

           tbPais pais = new tbPais { nombrePais=nombrepais,codigoPais=codpais };

            using (var db = new BD_Practica1())
            {
                db.tbPais.Add(pais);
                db.SaveChanges();
            }
            Console.WriteLine("se registro corrrectamente");
            Console.ReadLine();

        }


        public void ActualizarPais()
        {
            Console.Clear();
            Console.WriteLine("ingrese el Id de Pais a editar : ");
            int idPais = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese el nuevo nombre del pais ");
            string nombrepais = Console.ReadLine();
            using (var db = new BD_Practica1())
            {
                tbPais pais = db.tbPais.Find(idPais);
                pais.nombrePais = nombrepais;
                db.SaveChanges();

                Console.WriteLine("El pais con codigo :" + idPais + " se actualizo de manera correcta");
            }




        }
    }
}
