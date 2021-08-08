using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace Lab.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        private BD_Lab2Entities conn = new BD_Lab2Entities();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string user, string password)
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
    }
}