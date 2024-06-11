using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Posledna.Models;

namespace Posledna.Controllers
{
    
    public class TrainingProgramsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TrainingPrograms
        
        public ActionResult Index()
        {
            var trainingPrograms = db.TrainingPrograms.Include(t => t.Coach);
            return View(trainingPrograms.ToList());
        }

        // GET: TrainingPrograms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingProgram trainingProgram = db.TrainingPrograms.Find(id);
            if (trainingProgram == null)
            {
                return HttpNotFound();
            }
            return View(trainingProgram);
        }

        // GET: TrainingPrograms/Create
        public ActionResult Create()
        {
            ViewBag.CoachId = new SelectList(db.Coaches, "CoachId", "FirstName");
            return View();
        }

        // POST: TrainingPrograms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrainingProgramId,Name,Description,ImageUrl,CoachId")] TrainingProgram trainingProgram)
        {
            if (ModelState.IsValid)
            {
                db.TrainingPrograms.Add(trainingProgram);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CoachId = new SelectList(db.Coaches, "CoachId", "FirstName", trainingProgram.CoachId);
            return View(trainingProgram);
        }

        // GET: TrainingPrograms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingProgram trainingProgram = db.TrainingPrograms.Find(id);
            if (trainingProgram == null)
            {
                return HttpNotFound();
            }
            ViewBag.CoachId = new SelectList(db.Coaches, "CoachId", "FirstName", trainingProgram.CoachId);
            return View(trainingProgram);
        }

        // POST: TrainingPrograms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrainingProgramId,Name,Description,ImageUrl,CoachId")] TrainingProgram trainingProgram)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trainingProgram).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CoachId = new SelectList(db.Coaches, "CoachId", "FirstName", trainingProgram.CoachId);
            return View(trainingProgram);
        }

   
        public ActionResult Delete(int id)
        {
            TrainingProgram trainingProgram = db.TrainingPrograms.Find(id);
            db.TrainingPrograms.Remove(trainingProgram);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult AddAthlete(int id)
        {
            TrainingProgramAthletes model=new TrainingProgramAthletes();
            model.TrainingProgramId = id;
            model.TrainingProgram = db.TrainingPrograms.Find(id);
            model.Athletes=db.Athletes.ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAthlete(TrainingProgramAthletes model)
        {
            var athlete = db.Athletes.Find(model.AthleteId);
            var trainingProgram = db.TrainingPrograms.Find(model.TrainingProgramId);
            trainingProgram.Athletes.Add(athlete);
            db.SaveChanges();
            return View("Index",db.TrainingPrograms.ToList());
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
