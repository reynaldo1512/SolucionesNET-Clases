using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Lab.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private Conn_DB conn = new Conn_DB();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string user , string password)
        {

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password))
            {
                var usuario = conn.tbUsuario.FirstOrDefault(p => p.nombreUsuario == user && p.contraseña == password);
               
                if (usuario != null)
                {
                    
                   
                    Session["usuario"] = user;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }


            //if (login.nombreUsuario == "Reynaldo10" && login.contraseña == "123456")
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            //else
            //{
            //    return View();
            //}

            else
            {
                return View();
            }
           
            
            
        }
        public ActionResult CerrarSesion()
        {
            Session.Contents.RemoveAll();
            return RedirectToAction("Login", "Login");
        }

        //public ActionResult ValidacionLogin()
        //{
        //    string _StringConnection = ConfigurationManager.ConnectionStrings["Conn_BD2"].ConnectionString;

            
        //    {

                

        //            //create procedure SP_ValidarUsuario
        //            //@nombreUsuario nvarchar(20),
        //            //@contraseña nvarchar(20)
        //            //as
        //            //begin
        //            //select* from tbUsuario where nombreUsuario = @nombreUsuario and contraseña = @contraseña
        //            //end
        //        //    using (var con = new SqlConnection(_StringConnection))
        //        //    {
        //        //        using (var cmd = new SqlCommand("SP_ValidarUsuario", con))
        //        //        {
        //        //            cmd.CommandType = CommandType.StoredProcedure;

        //        //            con.Open();
        //        //        cmd.Parameters.Add("@nombreUsuario", SqlDbType.NVarChar, 20).Value=

        //        //            using (var dr = cmd.ExecuteReader())
        //        //            {
        //        //                if (dr.Read())
        //        //                {
        //        //                    return RedirectToAction("Index","Home");
        //        //                }


        //        //            }
        //        //        }

        //        //    }
        //        //return View();
                
        //    }
        //}

    }
}