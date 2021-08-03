using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace Lab.Controllers
{
    public class PacienteController : Controller
    {
        private Conn_DB conn = new Conn_DB();
        // GET: Paciente
        public ActionResult Index()
        {
            return View(conn.tbPaciente.ToList());
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            ViewBag.ListaSexo = conn.tbSexo.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(tbPaciente paci)
        {
            conn.tbPaciente.Add(paci);
            conn.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}