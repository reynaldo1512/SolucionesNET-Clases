using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace LAB.Controllers
{
    public class TipoExamenController : Controller
    {
        private Conn_DB conn = new Conn_DB();
        // GET: TipoExamen
        public ActionResult Index()
        {
            return View(conn.tbExamen.ToList());
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


    }
}