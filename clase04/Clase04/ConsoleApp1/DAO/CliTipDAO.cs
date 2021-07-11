using Clase04.BEAN;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04.DAO
{
   public  class CliTipDAO
    {

        #region CadenaConexion 

        string _StringConnection = ConfigurationManager.ConnectionStrings["ConnBD"].ConnectionString;

        #endregion

        public List<CliTipBEAN> ListaCliTip()
        {
            List<CliTipBEAN> lista = new List<CliTipBEAN>();
            CliTipBEAN Clitip;
            try
            {
                //cadena de conexion
                using (var con= new SqlConnection(_StringConnection))
                 
                  
                {
                    //ejecucion del procedimiento
                    using (var cmd= new  SqlCommand("SP_JOIN_CLI_TIPO",con))
                    { 
                        //que tipo de comando es 
                        cmd.CommandType = CommandType.StoredProcedure;
                        //abro conexion
                        con.Open();
                        
                        using (var dr=cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Clitip = new CliTipBEAN(); // cada vez que se enta al while se genera un nuevo objeto
                                Clitip.Id_Cliente = Convert.ToInt32(dr[0]);
                                Clitip.Nombre_Cliente = Convert.ToString(dr[1]);
                                Clitip.Apellidos_Cliente = Convert.ToString(dr[2]);
                                Clitip.Nombre_TipDoc = Convert.ToString(dr[3]);
                                lista.Add(Clitip);

                            }
                            

                        }
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

           

            return lista;

        }
    }
}
