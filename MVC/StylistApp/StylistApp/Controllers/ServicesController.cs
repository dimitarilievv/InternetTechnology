using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StylistApp.Models;

namespace StylistApp.Controllers
{
    public class ServicesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Services
        public ActionResult Index()
        {
            var services = db.Services.Include(s => s.Stylist);
            return View(services.ToList());
        }

        // GET: Services/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = db.Services.Include(s => s.Customers).FirstOrDefault(S => S.ServiceId == id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        // GET: Services/Create
        public ActionResult Create()
        {
            ViewBag.StylistId = new SelectList(db.Stylists, "StylistId", "FirstName");
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServiceId,ServiceName,Description,Price,ImageUrl,StylistId")] Service service)
        {
            if (ModelState.IsValid)
            {
                db.Services.Add(service);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StylistId = new SelectList(db.Stylists, "StylistId", "FirstName", service.StylistId);
            return View(service);
        }

        // GET: Services/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = db.Services.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            ViewBag.StylistId = new SelectList(db.Stylists, "StylistId", "FirstName", service.StylistId);
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServiceId,ServiceName,Description,Price,ImageUrl,StylistId")] Service service)
        {
            if (ModelState.IsValid)
            {
                db.Entry(service).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StylistId = new SelectList(db.Stylists, "StylistId", "FirstName", service.StylistId);
            return View(service);
        }




        public ActionResult Delete(int id)
        {
            Service service = db.Services.Find(id);
            db.Services.Remove(service);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddCustomer(int id)
        {
            ServiceCustomers model=new ServiceCustomers();
            model.ServiceId = id;
            model.Service=db.Services.Find(id);
            model.Customers=db.Customers.ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddCustomer(ServiceCustomers model)
        {
            var customer = db.Customers.Find(model.CustomerId);
            var service = db.Services.Find(model.ServiceId);
            service.Customers.Add(customer);
            db.SaveChanges();
            return View("Index",db.Services.ToList());
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
