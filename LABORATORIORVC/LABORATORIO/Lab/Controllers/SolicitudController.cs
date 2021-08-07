using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace Lab.Controllers
{
    public class SolicitudController : Controller
    {
        private Conn_DB conn = new Conn_DB();
        // GET: Solicitud
        public ActionResult Index()
        {
            string user = Convert.ToString(Session["usuario"]);
            if (user == "")
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return View(conn.tbSolicitudExamen.ToList());
            }
        }

        [HttpGet]
        public ActionResult Nuevo(int id)

        {

            ViewBag.id = id;
             List<tbExamen> examen = conn.tbExamen.Where(e => e.estado).ToList();

            return View(examen);


           

            
            
        }
        


    }
}