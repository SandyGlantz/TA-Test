using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ACME.Models;

namespace ACME.Controllers
{
    public class ProductsController : Controller
    {
        private ACMEProductsEntities db = new ACMEProductsEntities();




        // GET: Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }




        // GET: Products/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }




        // GET: Products/Create
        // displays form to user ... a response to a "request"
        [HttpGet] // Get is the Http default - same as [Http]
        public ActionResult Create()
        {
            return View();
        }




        // POST: Products/Create
        // displays to user AFTER user enters (posts) to site/Db ... a response to a "send"

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,Name,Price")] Product product)
        {
            // vid 17: validation
            // this is a manual validation after [required] taken out of ProductMetaData
            //  and Web.config (NOT Views > web.config) Validation line 15 changed to false

            // this was commented out in an earlier lesson ... 
            // and whatever else changed nolonger keeps the value in a certain range
            //     so I'm putting back in even tough it was called out in any lesson vid
            // and commenting back out because it's not being reached :-/
            /*
            if (string.IsNullOrEmpty(product.Name))
            {
                ModelState.AddModelError("Name", "All products need a name. Source: ProductsController.");             
            }


            if (ModelState.IsValidField("Price")
                && (product.Price < 0.10M)
                || (product.Price > 1000M))
            {
                ModelState.AddModelError("Price", 
                    "Please enter an amount between $0.10 and $1,000.00 ...  Source: ProductsController.");
            }
            */
            // end of what was commented out in earlier lesson (one of the earlier validation vids)
            // re-commented out because it's not being reached :-/

            if (ModelState.IsValid)
            {
                product.ProductId = Guid.NewGuid();
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index"); // This is where you would send a user to a confirmation page, etc.
            }

            return View(product);
        }







        // =====  EARLIER VERSIONS of =============== (different and Active methods below) ======================
        // POST: Products/Create
        // displays to user AFTER user enters (posts) to site/Db ... a response to a "send"
        // ================================================================

        // original auto-generated version:
        /*
           public ActionResult Create([Bind(Include = "ProductId,Name,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.ProductId = Guid.NewGuid();
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        */


        public ActionResult Create_EarlierLesson([Bind(Include = "ProductId,Name,Price")] Product product)
        {
            // this does the same thing as the commented out block above
            // BUT it is weakly Typed ... a wrong spelling and no error :-(
            // version 1 with public ActionResult Create()
            /*
            var product = new Product();
            product.ProductId = Guid.NewGuid();
            product.Name = Request["Name"];
            product.Price = Decimal.Parse(Request["Price"]);
            */

            // version 2 with public ActionResult Create(string Name, decimal Price)
            // makes sure the data Types are correct at least
            /*
            var product = new Product();
            product.ProductId = Guid.NewGuid();
            product.Name = Name;
            product.Price = Price;
            // this would then need a step here to save ito the dB
            */

            // version 3 with public ActionResult Create(Product product)
            //      the actually data Type Product - allowing access to the field
            // this is the same as the original auto-generated version
            // it utilizes ***** Model-Binding *****
            //  public ActionResult Create(Product product)
            if (ModelState.IsValid)
            {
                product.ProductId = Guid.NewGuid();
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            // last step was to add (back in) the binding into the function, resulting in:
            // public ActionResult Create([Bind(Include = "ProductId,Name,Price")] Product product)


            return View(product);
        }




        // GET: Products/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }





        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,Name,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }





        // GET: Products/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }





        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
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
