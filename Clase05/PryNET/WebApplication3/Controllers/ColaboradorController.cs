using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace WebApplication3.Controllers
{
    public class ColaboradorController : Controller
    {
        // GET: Colaborador
        private BD_CONTACTABILIDADEntities conn = new BD_CONTACTABILIDADEntities();
        public ActionResult Index()
        {
            return View(conn.tb_Colaborador.ToList());
        }

      [HttpGet]
        public ActionResult Nuevo()
        {
            ViewBag.ListaRoles = conn.tb_Rol.ToList();
            ViewBag.ListaDocumento = conn.tb_TipoDocumento.ToList();
            return View();
        }
        public ActionResult Nuevo(tb_Colaborador colaborador)
        {
            
            return RedirectToAction("Index");
            
        }
    }
}