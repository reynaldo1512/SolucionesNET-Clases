using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace Lab.Controllers
{
    public class TipoExamenController : Controller
    {

        private BD_Lab2Entities conn = new BD_Lab2Entities();
        // GET: TipoExamen
        public ActionResult Index( )
        {
            string user = Convert.ToString(Session["usuario"]);
            if (user == "")
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return View(conn.tbExamen.ToList());
            }
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(tbExamen exam)
        {
            conn.tbExamen.Add(exam);
            conn.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Editar(int id)
        {
            tbExamen exam = new tbExamen();
            exam = conn.tbExamen.Find(id);
            return View(exam);
        }
        [HttpPost]
        public ActionResult Editar(tbExamen examnew)
        {
            tbExamen exam = new tbExamen();
            exam = conn.tbExamen.Find(examnew.idExamen);
            exam.nombreExamen = examnew.nombreExamen;
            exam.precioUnidad = examnew.precioUnidad;
            exam.estado = examnew.estado;
            conn.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult Eliminar(int id)
        {
            tbExamen exam = new tbExamen();
            exam = conn.tbExamen.Find(id);
            exam.estado = false;
            conn.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}