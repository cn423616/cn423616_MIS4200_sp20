using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cn423616_MIS4200.DAL;
using cn423616_MIS4200.Models;

namespace cn423616_MIS4200.Controllers
{
    public class VisitDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: VisitDetails
        public ActionResult Index()
        {
            var visitDetails = db.VisitDetails.Include(v => v.Doctor).Include(v => v.Visit);
            return View(visitDetails.ToList());
        }

        // GET: VisitDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitDetail visitDetail = db.VisitDetails.Find(id);
            if (visitDetail == null)
            {
                return HttpNotFound();
            }
            return View(visitDetail);
        }

        // GET: VisitDetails/Create
        public ActionResult Create()
        {
            ViewBag.doctorID = new SelectList(db.Doctors, "doctorID", "firstName");
            ViewBag.visitID = new SelectList(db.Visits, "visitID", "description");
            return View();
        }

        // POST: VisitDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "visitDetailID,price,visitID,doctorID")] VisitDetail visitDetail)
        {
            if (ModelState.IsValid)
            {
                db.VisitDetails.Add(visitDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.doctorID = new SelectList(db.Doctors, "doctorID", "firstName", visitDetail.doctorID);
            ViewBag.visitID = new SelectList(db.Visits, "visitID", "description", visitDetail.visitID);
            return View(visitDetail);
        }

        // GET: VisitDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitDetail visitDetail = db.VisitDetails.Find(id);
            if (visitDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.doctorID = new SelectList(db.Doctors, "doctorID", "firstName", visitDetail.doctorID);
            ViewBag.visitID = new SelectList(db.Visits, "visitID", "description", visitDetail.visitID);
            return View(visitDetail);
        }

        // POST: VisitDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "visitDetailID,price,visitID,doctorID")] VisitDetail visitDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visitDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.doctorID = new SelectList(db.Doctors, "doctorID", "firstName", visitDetail.doctorID);
            ViewBag.visitID = new SelectList(db.Visits, "visitID", "description", visitDetail.visitID);
            return View(visitDetail);
        }

        // GET: VisitDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitDetail visitDetail = db.VisitDetails.Find(id);
            if (visitDetail == null)
            {
                return HttpNotFound();
            }
            return View(visitDetail);
        }

        // POST: VisitDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VisitDetail visitDetail = db.VisitDetails.Find(id);
            db.VisitDetails.Remove(visitDetail);
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
