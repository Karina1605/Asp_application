using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_1.Controllers
{
    public class HomeController : Controller
    {
        
        CustomersController customersController = new CustomersController();
        ProductsController products = new ProductsController();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
       
    }
}