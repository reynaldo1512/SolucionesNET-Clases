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
        public Boolean RegistrarRol(RolBEAN rol)
        {
            bool rpta = false;
            try
            {
                using (var con = new SqlConnection(_StringConnection))
                {
                    using (var cmd = new SqlCommand("SP_ROL_Insert ", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombreRol", rol.NombreRol);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        rpta = true;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            return rpta;
        }
        public RolBEAN  BuscarRolId(int IdRol)
        {


           /* CREATE PROCEDURE SP_ROL_BuscarIdRol
                    @idRol as int
                        as
                begin
                select* from tb_Rol where idRol like @idRol;
                end
                go
                   select* from tb_Rol
           */

            
            RolBEAN rol = new RolBEAN();
            
           
                using (var con = new SqlConnection(_StringConnection))
                {
                    using (var cmd = new SqlCommand("SP_ROL_BuscarIdRol", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idRol", IdRol);
                        con.Open();
                        using (var datos=cmd.ExecuteReader())
                        {
                            if(datos.Read())
                            {
                                
                                rol.IdRol = Convert.ToInt32(datos[0]);
                                rol.NombreRol = Convert.ToString(datos[1]);
                                

                            }

                        }
                        



                    }

                }

            
            return rol;
        }

        public List<RolBEAN> RegistroListadoRol(RolBEAN pRolBEAN)
        {
            List<RolBEAN> lista = new List<RolBEAN>();
            RolBEAN rol;
            try
            {
                using (var con = new SqlConnection(_StringConnection))
                {
                    using (var cmd = new SqlCommand("SP_ROL_InsertarListar", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombreRol", pRolBEAN.NombreRol);
                        con.Open();
                        using (var datos = cmd.ExecuteReader())
                        {
                            while (datos.Read())
                            {
                                rol = new RolBEAN();
                                rol.IdRol = Convert.ToInt32(datos[0]);
                                rol.NombreRol = Convert.ToString(datos[1]);
                                lista.Add(rol);

                            }

                        }




                    }

                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            {

            }
        }

        
    }
}
