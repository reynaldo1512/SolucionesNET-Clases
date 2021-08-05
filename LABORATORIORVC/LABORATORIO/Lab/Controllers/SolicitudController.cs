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
            return View(conn.tbSolicitudExamen.ToList());
        }



    }
}