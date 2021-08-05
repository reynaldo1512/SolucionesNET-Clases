using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BEAN;

namespace Lab.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginBEAN login)
        {
            if (login.nombreUsuario=="Reynaldo10" && login.contraseña=="123456")
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View();
            }
            
        }

    }
}