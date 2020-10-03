using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InputNewCustomer()
        {
            return View("~/Views/Home/InputNewCustomerView.cshtml");
        }
        public ActionResult InputNewInstrument()
        {
            return View("~/Views/Home/InputNewInstrumentView.cshtml");
        }
        public ActionResult AllOrdersOfCustomer()
        {
            return View("~/Views/Home/InputEmailView.cshtml");
        }
        public ActionResult AllProducts()
        {
            return View("~/Views/Home/AllInstrumentsView.cshtml");
        }
    }
}