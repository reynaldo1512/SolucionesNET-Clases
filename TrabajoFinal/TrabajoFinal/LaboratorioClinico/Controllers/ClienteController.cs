using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace LaboratorioClinico.Controllers
{
    public class ClienteController : Controller
    {

        private ConnDB2 conn = new ConnDB2();
        // GET: Cliente
        public ActionResult Index()
        {
            return View(conn.tbCliente.ToList());
        }

       [HttpGet]
        public ActionResult Registro()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Registro(tbCliente cli)
        {
            conn.tbCliente.Add(cli);
            conn.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}