using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_ADO.BEAN;
using EF_ADO.DAO;

namespace EF_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            string rpta = "N";
            do
            {
                ClienteDAO clienteDAO = new ClienteDAO();
                PaisDAO paisDAO = new PaisDAO();
                TarjetaDAO tarjetaDAO = new TarjetaDAO();
                ViajeDAO viaje = new ViajeDAO();
                Console.Clear();
                Console.WriteLine("MENU SOPORTE ");
                Console.WriteLine("1- CRUD CLIENTE");
                Console.WriteLine("2- CRUD TARJETA");
                Console.WriteLine("3-CRUD PAIS");
                Console.WriteLine("4-CRUD VIAJE ADO.NET");
                Console.WriteLine("0-SALIR");


                Console.WriteLine("INGRESE OPCION");

                int opcion;
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)

                {

                    case 1:
                        string rpta1 = "N";
                        
                        do
                        {
                         Console.WriteLine("MANTENIMIENTO CLIENTE");
                        Console.WriteLine("1- REGISTRAR CLIENTE");
                        Console.WriteLine("2- LISTAR CLIENTE");
                        Console.WriteLine("3-ACTUALIZAR CLIENTE");
                        Console.WriteLine("0-SALIR");
                        Console.WriteLine("INGRESE OPCION");
                            int opcion1 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion1)
                            {
                                case 1:
                                    clienteDAO.RegistrarCliente();
                                    Console.WriteLine("Dese continuar?(S/N)");
                                    rpta = Console.ReadLine();
                                    break;
                                case 2:
                                    clienteDAO.ListaCliente();
                                    Console.WriteLine("Dese continuar?(S/N)");
                                    rpta = Console.ReadLine();
                                    break;
                                case 3:
                                    clienteDAO.ActualizarCliente();
                                    Console.WriteLine("Dese continuar?(S/N)");
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

                        

                        } while (rpta1=="S" || rpta1=="s");
                       




                        break;
                    case 2:


                        string rpta2 = "N";

                        do
                        {
                            Console.WriteLine("MANTENIMIENTO DE TARJETA ");
                            Console.WriteLine("1- REGISTRAR TARJETA");
                            Console.WriteLine("2- LISTAR TARJETA");
                            Console.WriteLine("3-ACTUALIZAR TARJETA");
                            Console.WriteLine("0-SALIR");
                            Console.WriteLine("INGRESE OPCION");
                            int opcion2 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    tarjetaDAO.RegistrarTarjeta();
                                    Console.WriteLine("Dese continuar?(S/N)");
                                    rpta = Console.ReadLine();
                                    break;
                                case 2:
                                    tarjetaDAO.ListaTarjeta();
                                    Console.WriteLine("Dese continuar?(S/N)");
                                    rpta = Console.ReadLine();
                                    break;
                                case 3:
                                    tarjetaDAO.ActualizarTarjeta();
                                    Console.WriteLine("Dese continuar?(S/N)");
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



                        } while (rpta2 == "S" || rpta2 == "s");




                        break;

                    case 3:
                        string rpta3 = "N";

                        do
                        {
                            Console.WriteLine("MANTENIMIENTO DE PAIS ");
                            Console.WriteLine("1- REGISTRAR PAIS");
                            Console.WriteLine("2- LISTAR PAIS");
                            Console.WriteLine("3-ACTUALIZAR PAIS");
                            Console.WriteLine("0-SALIR");
                            Console.WriteLine("INGRESE OPCION");
                            int opcion3 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion3)
                            {
                                case 1:
                                    paisDAO.RegistrarPais();
                                    Console.WriteLine("Dese continuar?(S/N)");
                                    rpta = Console.ReadLine();
                                    break;
                                case 2:
                                    paisDAO.ListaPais();
                                    Console.WriteLine("Dese continuar?(S/N)");
                                    rpta = Console.ReadLine();
                                    break;
                                case 3:
                                    paisDAO.ActualizarPais();
                                    Console.WriteLine("Dese continuar?(S/N)");
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



                        } while (rpta3 == "S" || rpta3 == "s");


                        break;
                    case 4:
                        string rpta4= "N";

                        do
                        {
                            ViajeDAO viajeDAO = new ViajeDAO();
                            Console.WriteLine("MANTENIMIENTO DE VIAJE ");
                            Console.WriteLine("1- REGISTRAR VIAJE");
                            Console.WriteLine("2- LISTAR VIAJE");
                          
                            Console.WriteLine("0-SALIR");
                            Console.WriteLine("INGRESE OPCION");
                            int opcion4 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion4)
                            {
                                case 1:
                                    ViajeBEAN viajeBEAN = new ViajeBEAN();
                                    tarjetaDAO.ListaTarjeta();
                                    Console.WriteLine("INGRESE ID DE TARJETA");
                                    viajeBEAN.IdTarjeta = Convert.ToInt32(Console.ReadLine());

                                    
                                    paisDAO.ListaPais();
                                    Console.WriteLine("INGRESE ID DE PAIS");
                                    viajeBEAN.IdPais = Convert.ToInt32(Console.ReadLine());


                                    Console.WriteLine("INGRESE FECHA DE INICIO DE VIAJE");
                                    viajeBEAN.FechaInicio = Convert.ToDateTime(Console.ReadLine());

                                    Console.WriteLine("INGRESE FECHA DE FIN DE VIAJE");
                                    viajeBEAN.FechaFin = Convert.ToDateTime(Console.ReadLine());

                                    Console.WriteLine("INGRESE EL ESTADO DE VIAJE  :A(abierto) o C(cerrado)");
                                    viajeBEAN.EstadoViaje = Convert.ToString(Console.ReadLine());

                                    bool rptaReg = viajeDAO.RegistrarViaje(viajeBEAN);
                                    if (rptaReg)
                                    {
                                        Console.WriteLine("Se registroc orrectamente");
                                    }
                                    else
                                    {
                                        Console.WriteLine("error en el registro del viaje");
                                    }
                                    Console.WriteLine("desea continuar ? (S/N)");
                                    rpta = Console.ReadLine();


                                    break;
                                case 2:
                                    List<ViajeBEAN> listaviaje = new List<ViajeBEAN>();
                                    listaviaje = viajeDAO.listaViaje();
                                    Console.WriteLine("LISTA VIAJE");
                                    
                                    Console.WriteLine("idviaje" + "      " + "id tarjeta " + "     " + "idpais" + "           " + "fechaInicioViaje" + "        " + "fechafinViaje" +
                                    "           " + "estadoViaje");

                                    foreach (var item in listaviaje)
                                    {
                                        Console.WriteLine(item.IdViaje+"              "+ item.IdTarjeta+ "              " + item.IdPais+ "              " + item.FechaInicio+ "      "+item.FechaFin + "          "
                                            +item.EstadoViaje);
                                    }
                                    Console.WriteLine("desea continuar ? (S/N)");
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



                        } while (rpta4 == "S" || rpta4 == "s");

                        break;
                    default:
                        Console.WriteLine("Valor Ingresado incorrecto");
                        Console.WriteLine("Desea Continuar?/(S/N)");
                        rpta = Console.ReadLine();

                        break;
                }

            } while (rpta == "S" || rpta == "s");
        }
    }
}
