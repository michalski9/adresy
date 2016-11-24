using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DaysContainer.Models;
using DaysContainer.ViewModels;
using System.Globalization;
using System.Threading;

namespace DaysContainer.Controllers
{
    public class DaysController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public JsonResult DatabaseCount() {
            
            var data = db.Days.Count();
            var first = db.Days.First().Id; 
            int last = db.Days
                            .ToList()
                            .LastOrDefault().Id;
            

return Json(new { data = data,first, last }, JsonRequestBehavior.AllowGet);
            if (data == null){
                return Json(new { data = "Brak danych" }, JsonRequestBehavior.AllowGet);
            }
            
            return Json(new { data = data }, JsonRequestBehavior.AllowGet);
        }

       
        public JsonResult Element(int Id) {

            var data = db.Days.Find(Id);

            return Json(new { data = data }, JsonRequestBehavior.AllowGet);
        }

        // GET: Days
        public ActionResult Index()
        {


            ViewBag.Test = "Gregory";
            return View(db.Days.ToList());
        }

        // GET: Days/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Day day = db.Days.Find(id);
            if (day == null)
            {
                return HttpNotFound();
            }
            return View(day);
        }

        // GET: Days/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Days/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Data,Godziny,Obecnosc,Temat,Ocena,Miejsce,Prowadzacy,Stopien_zadowolenia")] Day day)
        {
            if (ModelState.IsValid)
            {
                db.Days.Add(day);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(day);
        }

        // GET: Days/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Day day = db.Days.Find(id);
            if (day == null)
            {
                return HttpNotFound();
            }
            return View(day);
        }

        // POST: Days/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Data,Godziny,Obecnosc,Temat,Ocena,Miejsce,Prowadzacy,Stopien_zadowolenia")] Day day)
        {
            if (ModelState.IsValid)
            {
                db.Entry(day).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(day);
        }

        // GET: Days/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Day day = db.Days.Find(id);
            if (day == null)
            {
                return HttpNotFound();
            }
            return View(day);
        }

        // POST: Days/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Day day = db.Days.Find(id);
            db.Days.Remove(day);
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
        public ActionResult Licznik() {
            List<Models.Day> days = db.Days
                .ToList();
            ApplicationUser user = db.Users.First();

        UserDayViewModel viewModel = new UserDayViewModel();
            viewModel.Days = days;
            viewModel.User = user;

            return View(viewModel);
        }
    }
}
