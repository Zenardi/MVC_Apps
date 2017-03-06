using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class OrderFormViewModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OrderFormViewModels
        public ActionResult Index()
        {
            return View(db.OrderFormViewModel.ToList());
        }

        // GET: OrderFormViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderFormViewModel orderFormViewModel = db.OrderFormViewModel.Find(id);
            if (orderFormViewModel == null)
            {
                return HttpNotFound();
            }
            return View(orderFormViewModel);
        }

        // GET: OrderFormViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderFormViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ReferenceDate,CustomerName,ProductName,ProductUnitCost,Quantity,TotalValue")] OrderFormViewModel orderFormViewModel)
        {
            if (ModelState.IsValid)
            {
                db.OrderFormViewModel.Add(orderFormViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orderFormViewModel);
        }

        // GET: OrderFormViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderFormViewModel orderFormViewModel = db.OrderFormViewModel.Find(id);
            if (orderFormViewModel == null)
            {
                return HttpNotFound();
            }
            return View(orderFormViewModel);
        }

        // POST: OrderFormViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ReferenceDate,CustomerName,ProductName,ProductUnitCost,Quantity,TotalValue")] OrderFormViewModel orderFormViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderFormViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orderFormViewModel);
        }

        // GET: OrderFormViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderFormViewModel orderFormViewModel = db.OrderFormViewModel.Find(id);
            if (orderFormViewModel == null)
            {
                return HttpNotFound();
            }
            return View(orderFormViewModel);
        }

        // POST: OrderFormViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderFormViewModel orderFormViewModel = db.OrderFormViewModel.Find(id);
            db.OrderFormViewModel.Remove(orderFormViewModel);
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

        public IEnumerable<Customer> GetCustomers()
        {
            return db.Customers.ToList();
        }
    }
}
