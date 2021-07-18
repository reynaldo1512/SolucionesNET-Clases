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
    public class SemPlanDAO
    {

       

        #region CadenaConexion

        string _StringConnection = ConfigurationManager.ConnectionStrings["ConNBD"].ConnectionString;

        #endregion

        
            public  List<SemPlanBEAN> ListSemana()
        {

            List<SemPlanBEAN> Lista = new List<SemPlanBEAN>();

            SemPlanBEAN semana;
            try
            {
                using (var con=new SqlConnection(_StringConnection))
                {
                    using (var cmd= new SqlCommand("SP_SEMANA_LIST",con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        using (var dr= cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                semana = new SemPlanBEAN();
                                semana.IdSem = Convert.ToInt32(dr[0]);
                                semana.NombreSem = Convert.ToString(dr[1]);
                                semana.fechaInicio = Convert.ToDateTime(dr[2]);
                                semana.FechaFin = Convert.ToDateTime(dr[3]);
                                semana.Estado = Convert.ToInt32(dr[4]);
                               Lista.Add(semana);
                            }
                        }
                    }
                }

            }
            catch (Exception ex )
            {

                Console.WriteLine(ex.ToString());
            }

            return Lista;
        }
        

    }
}
