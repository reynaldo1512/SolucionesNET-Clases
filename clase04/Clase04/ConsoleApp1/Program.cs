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
            /*
            List<RolBEAN> ListaRol = new List<RolBEAN>();
             RolDAO rolDAO = new RolDAO();
             ListaRol = rolDAO.ListaRoles();
             foreach (var item in ListaRol)
             {
                 Console.WriteLine(item.IdRol + " " + item.NombreRol);
             }
             Console.ReadLine();
            
            */
            #endregion

            List<CliTipBEAN> listaClitip = new List<CliTipBEAN>();
            CliTipDAO clitipDAO = new CliTipDAO();
            listaClitip = clitipDAO.ListaCliTip();
            foreach (var item in listaClitip)
            {
                Console.WriteLine(item.Id_Cliente + " " + item.Nombre_Cliente +" "+ item.Apellidos_Cliente+" "+ item.Nombre_TipDoc);
            }
            Console.ReadLine();

            
        }

    }
}
