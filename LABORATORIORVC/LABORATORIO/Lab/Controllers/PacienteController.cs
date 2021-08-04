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
            return RedirectToAction("Index");

            

        }
    }
}