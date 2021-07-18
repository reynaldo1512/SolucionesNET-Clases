using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_ADO.modelo;
using EF_ADO.BEAN;
using System.Data.SqlClient;
using System.Data;

namespace EF_ADO.DAO
{
    public class ViajeDAO
    {
        string _StringConnection = ConfigurationManager.ConnectionStrings["ConnBD2"].ConnectionString;



        public List<ViajeBEAN> listaViaje()
        {
            List<ViajeBEAN> lista = new List<ViajeBEAN>();
            ViajeBEAN viaje;
           
            try
            {
                using (var con=new SqlConnection(_StringConnection))
                {

                    {

                        /* CREATE PROCEDURE SP_LIST_VIAJE
                            AS
                            SELECT idViaje,idTarjeta,idPais,fechaInicioViaje,fechaFinViaje,estadoViaje
                            FROM tbViaje
                            EXEC SP_LIST_VIAJE
                           */
                        using (var cmd=new SqlCommand("SP_LIST_VIAJE", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            con.Open();
                            using (var dr=cmd.ExecuteReader())
                            {

                                while (dr.Read())
                                {
                                    viaje = new ViajeBEAN();
                                    viaje.IdViaje = Convert.ToInt32(dr[0]);
                                    viaje.IdTarjeta = Convert.ToInt32(dr[1]);
                                    viaje.IdPais = Convert.ToInt32(dr[2]);
                                    viaje.FechaInicio = Convert.ToDateTime(dr[3]);
                                    viaje.FechaFin = Convert.ToDateTime(dr[4]);
                                    viaje.EstadoViaje = Convert.ToString(dr[5]);
                                    lista.Add(viaje);
                                }
                                

                            }

                        }

                    }

                }
            }
            catch (Exception ex )
            {

                Console.WriteLine(ex.ToString());
            }

            return lista; 
        }

        public Boolean RegistrarViaje(ViajeBEAN viaje)
        {
            bool rpta = false;
            try
            {
                using (var con = new SqlConnection(_StringConnection))
                {

                    /*
                     CREATE PROCEDURE SP_INSERT_VIAJE1
                    ( 
                    @idTarjeta int ,
                    @idPais int ,
                    @fechaInicioViaje datetime ,
                    @fechaFinViaje datetime ,
                    @estadoViaje nvarchar(1))
                    AS 
 
                     INSERT INTO tbViaje 
                        VALUES (@idTarjeta,@idPais,@fechaInicioViaje,@fechaFinViaje,@estadoViaje)
                        */
                    using (var cmd = new SqlCommand("SP_INSERT_VIAJE1", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        cmd.Parameters.AddWithValue("idTarjeta", viaje.IdTarjeta);
                        cmd.Parameters.AddWithValue("@idPais ", viaje.IdPais);
                        cmd.Parameters.AddWithValue("@fechaInicioViaje", viaje.FechaInicio);
                        cmd.Parameters.AddWithValue("@fechaFinViaje", viaje.FechaFin);
                        cmd.Parameters.AddWithValue("@estadoViaje", viaje.EstadoViaje);

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
    }
}
