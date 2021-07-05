using clase0003.DAO;
using clase0003.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase0003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /* List<tb_Categoria> listaCat = new List<tb_Categoria>();
            using (var db = new ConnDB_EF())
            {
                listaCat = db.tb_Categoria.ToList();
            }
            Console.WriteLine("Lista de Categoria");
            foreach (var item in listaCat)
            {
                Console.WriteLine(item.idCategoria + " " + item.nombreCategoria);
            }
            
            Console.ReadLine();
            */
            #endregion
            #region registrar categoria con EF

            /*
             string rpta = "N";
             int codMenu = 0;
             CategoriaDAO catDAO = new CategoriaDAO();
             ClienteDAO cliDAO = new ClienteDAO();

             do
             {
                 Console.Clear();
                 Console.WriteLine("BIENVENIDO AL MANTENIMIENTO CATEGORIA");
                 Console.WriteLine("-------------------------------------");
                 Console.WriteLine("1-Lista");
                 Console.WriteLine("2-registro");
                 Console.WriteLine("3-editar");
                 Console.WriteLine("4-eliminar");
                 Console.WriteLine("5-Lista Clientes");
                 Console.WriteLine("\n0-Salir");
                 Console.WriteLine("Ingrese el codigo en el menu : ");
                 codMenu = Convert.ToInt32(Console.ReadLine());
                 switch (codMenu)
                 {
                     case 1:
                         catDAO.ListaCategoria();
                         Console.WriteLine("Desea continuar?(S/N)");
                         rpta = Console.ReadLine();
                         break;
                     case 2:
                         catDAO.RegistaCategoria();
                         catDAO.ListaCategoria();
                         Console.WriteLine("Desea continuar ?(S/N)");
                         rpta = Console.ReadLine();
                         break;
                     case 3:
                         catDAO.EditarCategoria();
                         Console.WriteLine("Desea continuar ?(S/N)");
                         rpta = Console.ReadLine();
                         break;
                     case 4:
                         catDAO.EliminarCategoria();
                         Console.WriteLine("Desea continuar ?(S/N)");
                         rpta = Console.ReadLine();
                         break;
                     case 5:
                         cliDAO.ListaClientesTipDoc();
                         Console.WriteLine("Desea continuar ?(S/N)");
                         rpta = Console.ReadLine();
                         break;

                     case 0:
                         Console.WriteLine("Gracias por su visita");
                         rpta = "N";
                         break;
                     default:
                         Console.WriteLine("Valor Ingresado incorrecto");
                         Console.WriteLine("Desea Continuar?/(S/N)");
                         rpta = Console.ReadLine();
                         break;
                 }



             } while (rpta=="S" || rpta=="s");
            */



            #endregion

            #region Contactabilidad

            

          

            ContactabilidadDAO contDAO = new ContactabilidadDAO();
            ColaboradorDAO colaDAO = new ColaboradorDAO();
            ClienteDAO cliDAO = new ClienteDAO();
            ProductoDAO prodDAO = new ProductoDAO();
            Console.WriteLine("BIENVENIDO");

            contDAO.ListaContact();
            colaDAO.ListaColaborador();
            prodDAO.ListaProducto();
            cliDAO.ListaCliente();




            contDAO.RegistrarContact();







            #endregion

        }
    }
    }

