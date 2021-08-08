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
        private BD_Lab2Entities conn = new BD_Lab2Entities();
        // GET: Paciente
        public ActionResult Busqueda(string DNI)
        {
            string user = Convert.ToString(Session["usuario"]);
            if (user == "")
            {
                return RedirectToAction("Login", "Login");
            }

            else
            {
                using (var db = new BD_Lab2Entities())
                {

                    var busqueda = from s in db.tbPaciente select s;

                    if (!String.IsNullOrEmpty(DNI))
                    {
                        busqueda = busqueda.Where(s => s.dni.Contains(DNI));
                    }
                    return View(busqueda.ToList());


                }
            }
            
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
            return RedirectToAction("Busqueda");
        }
        public ActionResult Editar(int id)

        {
            
            tbPaciente paciente = new tbPaciente();
            paciente = conn.tbPaciente.Find(id);
            ViewBag.ListaSexo = conn.tbSexo.ToList();
            return View(paciente);

            
        }
        [HttpPost]
        public ActionResult Editar(tbPaciente pacientenew)
        {
            tbPaciente paciente = new tbPaciente();
            paciente = conn.tbPaciente.Find(pacientenew.idPaciente);
            paciente.dni = pacientenew.dni;
            paciente.nombrePaciente = pacientenew.nombrePaciente;
            paciente.apellidoPaciente = pacientenew.apellidoPaciente;
            paciente.direccion = pacientenew.direccion;
            paciente.idSexo = pacientenew.idSexo;
            paciente.telefono = pacientenew.telefono;
            paciente.fechaNacimiento = pacientenew.fechaNacimiento;
            conn.SaveChanges();
            return RedirectToAction("Busqueda");

            

        }
    }
}