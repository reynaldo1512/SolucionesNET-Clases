using clase0003.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase0003.DAO
{
   public class ProductoDAO
    {
        public void ListaProducto()
        {
            List<tb_Producto> ListaProd = new List<tb_Producto>();
            using (var db= new ConnDB_EF())
            {
                ListaProd = db.tb_Producto.ToList();
            }
            Console.WriteLine("Lista de Producto");
            foreach (var item in ListaProd)
            {
                Console.WriteLine(item.idProducto+" "+ item.nombreProducto+ " " + item.descripcionProducto + " " +item.estadoProducto);
            }
            Console.ReadLine();
        }
    }
}
