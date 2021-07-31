using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace WebApplication3.Controllers
{
    public class ProductoController : Controller
    {
        private BD_CONTACTABILIDADEntities  conn =new BD_CONTACTABILIDADEntities();
        // GET: Producto
        public ActionResult Index()
        {
            return View(conn.tb_Producto.ToList());
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }
        [HttpPost]
        public ActionResult New(tb_Producto product)
        {
            conn.tb_Producto.Add(product);
            conn.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {

            tb_Producto product = new tb_Producto();
            product = conn.tb_Producto.Find(id);

            return View(product);

        }
        [HttpPost]

        public ActionResult Edit(tb_Producto productnew)
        {

            tb_Producto product = new tb_Producto();
            product = conn.tb_Producto.Find(productnew.idProducto);
            product.nombreProducto = productnew.nombreProducto;
            product.descripcionProducto = productnew.descripcionProducto;
            product.estadoProducto = productnew.estadoProducto;
            conn.SaveChanges();
            return RedirectToAction("index");

        }

        public ActionResult Delete(int id)
        {
            tb_Producto product = new tb_Producto();
            product = conn.tb_Producto.Find(id);
            product.estadoProducto = false;
            conn.SaveChanges();
            return RedirectToAction("index");



        }
    }
}