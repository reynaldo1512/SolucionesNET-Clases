using Clase04.DAO;
using Clase04.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lista Rol

            /*  List<RolBEAN> ListaRol = new List<RolBEAN>();
              RolDAO rolDAO = new RolDAO();
              ListaRol = rolDAO.ListaRoles();
              foreach (var item in ListaRol)
              {
                  Console.WriteLine(item.IdRol + " " + item.NombreRol);
              }
            */
            
           

            string rpta = "N";
            do
            {
                RolDAO rolDAO = new RolDAO();
                Console.Clear();
                Console.WriteLine("mantenimiento de roles");
                Console.WriteLine("1- lista roles");
                Console.WriteLine("2-registro roles ");
                Console.WriteLine("3-buscar por idRoles");
                Console.WriteLine("4-Insertar y Listar");
                Console.WriteLine("0-salir");
                Console.WriteLine("ingrese opcion");
                int opcion;
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {

                    case 1:
                        List<RolBEAN> listarol = new List<RolBEAN>();
                        
                        listarol = rolDAO.ListaRoles();
                        Console.Clear();
                        Console.WriteLine("Lista roles");
                        foreach (var item in listarol)
                        {
                            Console.WriteLine(item.IdRol+ "\t"+ item.NombreRol  );
                        }
                        Console.WriteLine("desea continuar ? (S/N)");
                        rpta = Console.ReadLine();
                        break;
                         
                    case 2:
                        RolBEAN rolBEAN = new RolBEAN();
                        Console.WriteLine("ingrese el nombre del rol");
                        rolBEAN.NombreRol = Console.ReadLine();

                        bool rptaReg =rolDAO.RegistrarRol(rolBEAN);
                        if (rptaReg)
                        {
                            Console.WriteLine("registrado correctamente");
                        }
                        else
                        {
                            Console.WriteLine("error en registro de rol");
                        }
                        Console.WriteLine("desea continuar ? (S/N)");
                        rpta = Console.ReadLine();
                        break;

                    case 3:
                        
                        Console.WriteLine("iNGRESE EL ID A BUSCAR");
                        int id  = Convert.ToInt32(Console.ReadLine());
                        RolBEAN rolBEAN1 = new RolBEAN();
                        rolBEAN1 = rolDAO.BuscarRolId(id);
                        if (rolBEAN1.IdRol==0)
                        {
                            Console.WriteLine("no hay un registro con ese id ");
                        }

                        Console.WriteLine(rolBEAN1.IdRol+" " + rolBEAN1.NombreRol);
                        
                        Console.WriteLine("desea continuar ? (S/N)");
                        rpta = Console.ReadLine();

                        break;

                    default:
                        break;
                }




            } while (true);
             
            
            
            #endregion

            /*List<CliTipBEAN> listaClitip = new List<CliTipBEAN>();
            CliTipDAO clitipDAO = new CliTipDAO();
            listaClitip = clitipDAO.ListaCliTip();
            foreach (var item in listaClitip)
            {
                Console.WriteLine(item.Id_Cliente + " " + item.Nombre_Cliente +" "+ item.Apellidos_Cliente+" "+ item.Nombre_TipDoc);
            }
            Console.ReadLine();}*/
            
            /*
            // semanaplan
            List<SemPlanBEAN> listsemplans = new List<SemPlanBEAN>();
            SemPlanDAO semplanDAO = new SemPlanDAO();
            listsemplans = semplanDAO.ListSemana();

            foreach (var item in listsemplans)
            {
                Console.WriteLine(item.IdSem+" " + item.NombreSem + " " + item.fechaInicio+" " + item.FechaFin + " " + item.Estado);

            }


            Console.ReadLine();
            */


            
        }

    }
}
