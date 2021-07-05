using clase0003.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase0003.DAO
{
   public class ColaboradorDAO
    {
        public void ListaColaborador()
        {
            List<tb_Colaborador> ListaCol = new List<tb_Colaborador>();
            using (var db = new ConnDB_EF())
            {
                ListaCol = db.tb_Colaborador.ToList();
            }
            Console.WriteLine("Lista colaborador");
            foreach (var item in ListaCol)
            {
                Console.WriteLine(item.idColaborador + " " + item.nombreColaborador + " " + item.apellidoColaborador+ " " + item.numeroDocumentoColaborador+" " 
                   );
            }
            Console.ReadLine();
        }
    }
}
