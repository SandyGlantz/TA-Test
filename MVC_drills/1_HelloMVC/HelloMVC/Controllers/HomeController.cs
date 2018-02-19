using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var cars = HelloModel.GetCars();

            ViewBag.CreatedViewBagValue = "Hello from created ViewBag value";

            return View(cars);
        }
    }
}