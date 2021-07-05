using clase0003.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase0003.DAO
{
    public class CategoriaDAO
    {
        public void ListaCategoria()
        {
            Console.Clear();

            List<tb_Categoria> listaCat = new List<tb_Categoria>();
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
        }



        public void RegistaCategoria()
        {
            Console.Clear();
            Console.WriteLine("Ingrese nombre de categoria: ");
            string nombreCat = Console.ReadLine();
            tb_Categoria cat = new tb_Categoria { nombreCategoria = nombreCat };
            using (var db = new ConnDB_EF())
            {
                db.tb_Categoria.Add(cat);
                db.SaveChanges();
            }
            Console.WriteLine("se registro correctamente");
            Console.ReadLine();
        }
        public void EditarCategoria()
        {


            Console.Clear();
            ListaCategoria();
            Console.Write("Ingrese el ID  de categoria a editar : ");

            int idCat = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el nuevo nombre");
            string NombreCat = Console.ReadLine();
            using (var db = new ConnDB_EF())
            {
                tb_Categoria cat = db.tb_Categoria.Find(idCat);
                cat.nombreCategoria = NombreCat;
                db.SaveChanges();
                Console.WriteLine("el regitro con codigo:" + idCat + "se edito correctamente");
            }


        }
        public void EliminarCategoria()
        {
            Console.Clear();
            ListaCategoria();
            Console.Write("Ingrese el ID  de categoria a eliminar : ");
          
            int idCat = Convert.ToInt32(Console.ReadLine());
            string NombreCat = Console.ReadLine();
            using (var db = new ConnDB_EF())
            {
                db.tb_Categoria.Remove(db.tb_Categoria.Find(idCat));
                db.SaveChanges();
                Console.WriteLine("Se elimino correctamente");

            }
        }
       
    }
}
