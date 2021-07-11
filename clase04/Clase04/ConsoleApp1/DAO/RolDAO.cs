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
    class RolDAO
    {
        #region Cadena de conexion
        string _StringConnection = ConfigurationManager.ConnectionStrings["ConnBD"].ConnectionString;
        #endregion
        public List<RolBEAN> ListaRoles()
        {
            List<RolBEAN> lista = new List<RolBEAN>(); // mi lista es de tipo RolBEAN 
            RolBEAN rol; //VARIABLE DE TIPO RolBEAN : se utilizara en el while (dr.Read)
                         // RolBEAN rol = new RolBEAN(); es igual que RolBEAN rol;
                         //proceso
            try
            {
                // cadena de conexion 
                using ( var con =new SqlConnection(_StringConnection)) // el using hace la apertura de la clase y apenas salfa de las llaves se destruye(buenas practicas )
                {
                    //ejecucion del procedimiento
                    using (var cmd= new SqlCommand("SP_ROL_LIST",con)) // nombre del procecimiento , cadena de conexion 
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        // como esta en using se rompe la conexion y no debo de cerrar la conexion
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read()) // hace que lea solo las filas que estan en la tabla de la base de datos  
                            {
                                rol = new RolBEAN(); // cada vez que se enta al while se genera un nuevo objeto 
                                rol.IdRol = Convert.ToInt32(dr[0]);
                                rol.NombreRol = Convert.ToString(dr[1]);
                                lista.Add(rol);

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
