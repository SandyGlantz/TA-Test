using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var categories = new List<SelectListItem> {
                new SelectListItem { Text = "Claw Classics", Value = "C" }, 
                new SelectListItem { Text = "Staff Recommends", Value = "S" }, 
                new SelectListItem { Text = "Cat Club Selection", Value = "BC" }, 
                new SelectListItem { Text = "Most Purrpular", Value = "P" } 
            };

            ViewBag.Categories = categories;

            return View();
        }
    }
}