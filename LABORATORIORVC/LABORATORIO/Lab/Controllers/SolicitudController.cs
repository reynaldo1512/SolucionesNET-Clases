using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;
using Lab.Models;

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
        public ActionResult Guardar(SolicitudExamenViewModel solicitud)
        {
           

            using (var transaction = conn.Database.BeginTransaction())
            {
                try
                {
                    tbSolicitudExamen solicitar = new tbSolicitudExamen { idUsuario=1,Total=solicitud.Total};
                    conn.tbSolicitudExamen.Add(solicitar);
                    conn.SaveChanges();
                    foreach(tbExamen item in solicitud.Examenes)
                    {
                        tbDetalleSolicitudExamen detallesolicitudExamen = new tbDetalleSolicitudExamen();
                        {
                            detallesolicitudExamen.idExamen = item.idExamen;
                            detallesolicitudExamen.idSolicitudExamen = solicitar.idSolicitudExamen; 
        
                        };
                        conn.tbDetalleSolicitudExamen.Add(detallesolicitudExamen);
                    }
                    conn.SaveChanges();
                     
                    transaction.Commit();

                }
                catch(Exception e)
                {
                    transaction.Rollback();

                }
            }

            return RedirectToAction("Index");
            
           
        }
        
        


    }
}