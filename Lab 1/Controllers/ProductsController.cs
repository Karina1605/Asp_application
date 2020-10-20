using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab_1.Models;

namespace Lab_1.Controllers
{
    public class ProductsController : Controller
    {
        private ShopBaseContext db = new ShopBaseContext();

        // GET: Products
        public ActionResult Index()
        {
            return View("~/Views/Products/Index.cshtml", db.Instruments.ToList());
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View("~/Views/Products/Create.cshtml");
        }

        // POST: Products/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,Cost")] Product product)
        {

            if (ModelState.IsValid)
            {

                db.Instruments.Add(product);
                db.SaveChanges();
                return Index();
            }

            return View(product);
        }

        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
