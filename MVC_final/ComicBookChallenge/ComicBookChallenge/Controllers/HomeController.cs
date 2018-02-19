using ComicBookChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var comics = ComicBookManager.GetComicBooks();
            return View(comics);
        }


        public ActionResult Detail(int id)
        {
            var comics = ComicBookManager.GetComicBooks();
            var comic = comics.FirstOrDefault(p => p.ComicBookId == id);

            return View(comic);
        }
    }
}
