using clase0003.BEAN;
using clase0003.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase0003.DAO
{
   public class ClienteDAO
         


    
        
        {
            public void ListaCliente()
            {
                List<tb_Cliente> ListaCliente = new List<tb_Cliente>();
                using (var db = new ConnDB_EF())
                {
                    ListaCliente = db.tb_Cliente.ToList();
                }
                Console.WriteLine("Lista de clientes");
                foreach (var item in ListaCliente)
                {
                    Console.WriteLine(item.idCliente + " " + item.nombreCliente + " " + item.apellidosCliente + " " + item.fechaNacimientoCliente);
                }
                Console.ReadLine();
            }
        }















        /*
       public void ListaClientesTipDoc()
       {

           // select cli.idCliente, cli.nombreCliente, cli.apellidosCliente , cli.numeroDocumentoCliente ,td.nombreTipoDocumento,cat.nombreCategoria
           //from tb_Cliente cli 
           //inner join tb_TipoDocumento td
           //on cli.idTipoDocumento= td.idTipoDocumento 
           //inner join tb_Categoria cat 
           //on cli.idCategoria=cat.idCategoria 
           List<ClienteBEAN> ListaCliente;
           using (var db = new ConnDB_EF())
           {
               var _Datos = from cli in db.tb_Cliente
                                join td in db.tb_TipoDocumento 
                                on cli.idTipoDocumento equals td.idTipoDocumento  
                               join cat in db.tb_Categoria 
                               on cli.idCategoria equals cat.idCategoria


                                select new ClienteBEAN
                                {
                                    IdCliente = cli.idCliente,
                                    NombreCliente = cli.nombreCliente,
                                    ApellidoCliente = cli.apellidosCliente,
                                    NumDocCliente = cli.numeroDocumentoCliente,
                                    TipDoc = td.nombreTipoDocumento,
                                    NombreCat=cat.nombreCategoria


                                };
               ListaCliente = _Datos.ToList();
           }
           Console.WriteLine("Lista de Clientes  y tipo de documento");
           Console.WriteLine("Id Cliente \t Nombres \t Apellidos \t Num Doc \t Tip Doc \t \t \t  NombreCat");
           foreach (var item in ListaCliente)
           {
               Console.WriteLine(item.IdCliente + "\t\t"
                   + item.NombreCliente + "\t\t"
                   + item.ApellidoCliente+ "\t\t"
                   +item.NumDocCliente+ "\t\t"
                   +item.TipDoc + "\t\t"
                   + item.NombreCat);
           }
       }
   }
  */

    }
    
