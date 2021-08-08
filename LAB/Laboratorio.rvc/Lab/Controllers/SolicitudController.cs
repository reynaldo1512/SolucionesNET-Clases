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
        private BD_Lab2Entities conn = new BD_Lab2Entities();
        // GET: SolicitudExamen
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
                      
            ViewBag.Examen = conn.tbExamen.ToList();
            ViewBag.Usuario = conn.tbUsuario.ToList();
            //List<tbExamen> examen = conn.tbExamen.Where(e => e.estado).ToList();

            return View();

        }
        [HttpPost]
        public ActionResult Nuevo(tbSolicitudExamen solic)
        {
            conn.tbSolicitudExamen.Add(solic);
            conn.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}