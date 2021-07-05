using clase0003.BEAN;
using clase0003.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase0003.DAO
{
    public class ContactabilidadDAO
    {
        public void ListaContact()
        {
            List<ContactabilidadBEAN> ListaContactabilidad;
            using (var db = new ConnDB_EF())
            {
                var datos = from cont in db.tb_ContactoCliente
                            join col in db.tb_Colaborador
                            on cont.idColaborador equals col.idColaborador
                            join pro in db.tb_Producto
                            on cont.idProducto equals pro.idProducto

                            select new ContactabilidadBEAN
                            {
                                IdContact = cont.idContactabilidad,
                                Idcola = cont.idColaborador,
                                IdProd = cont.idProducto,
                                FechaContact=cont.fechaContactoCliente,
                                comen=cont.comentarioContactoCliente,
                                estado=cont.estadoContactoCliente
                                
                                
                            };
                ListaContactabilidad = datos.ToList();
            }
            Console.WriteLine("Lista");
            Console.WriteLine("IdContact \t Idcola \t IdProd \t FechaContac \t comentario \t estado ");
            foreach (var item in ListaContactabilidad)
            {
                Console.WriteLine(item.IdContact + "\t\t"
                    + item.Idcola + "\t\t"
                    + item.IdProd + "\t\t"
                    + item.FechaContact + "\t\t"
                    +item.comen + "\t\t"
                    +item.estado);
            }
        }
        public void RegistrarContact()
        {

           
            Console.WriteLine("REGISTRAR CONTACTO");
            string comen = "-";
            string estado = "A";
            DateTime fecha = DateTime.Now;
            Console.Clear();
            Console.WriteLine("Ingrese id del colaborador ");
            int idcola = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese id del cliente");
            int idcli = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese id del producto ");
            int idproduct = Convert.ToInt32(Console.ReadLine());

            tb_ContactoCliente cont = new tb_ContactoCliente { idColaborador = idcola ,idCliente=idcli,
                idProducto=idproduct,fechaContactoCliente=fecha,comentarioContactoCliente=comen,estadoContactoCliente=estado };

          

            using (var db = new ConnDB_EF())
            {
                db.tb_ContactoCliente.Add(cont);
                db.SaveChanges();
            }
            Console.WriteLine("se registro correctamente");
            Console.ReadLine();
        }


    }
}
