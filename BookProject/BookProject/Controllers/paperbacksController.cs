using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookProject.Models;

namespace BookProject.Controllers
{
    public class paperbacksController : Controller
    {
        private paperbackDBContext db = new paperbackDBContext();

        // GET: paperbacks
        public ActionResult Index(string searchstring)
        {
            var Paperbacks = from b in db.Paperback
                select b;

            if (!String.IsNullOrEmpty(searchstring))
            {
                Paperbacks = Paperbacks.Where(s =>s.Title.Contains(searchstring));
            }
            return View(Paperbacks);

        }

         

        public ActionResult Home()
        {
            return View(db.Paperback.ToList());
        }


        public ActionResult Search()
        {
            return View(db.Paperback.ToList());
        }

        public ActionResult Request()
        {
            return View(db.Paperback.ToList());
        }

        public ActionResult Thanks()
        {
            return View(db.Paperback.ToList());
        }

        public ActionResult Confirmation()
        {
            return View(db.Paperback.ToList());
        }

        public ActionResult Donate()
        {
            return View(db.Paperback.ToList());
        }

        // GET: paperbacks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            paperback paperback = db.Paperback.Find(id);
            if (paperback == null)
            {
                return HttpNotFound();
            }
            return View(paperback);
        }

        // GET: paperbacks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: paperbacks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ISBNNumber,Title,Author")] paperback paperback)
        {
            if (ModelState.IsValid)
            {
                db.Paperback.Add(paperback);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paperback);
        }

        // GET: paperbacks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            paperback paperback = db.Paperback.Find(id);
            if (paperback == null)
            {
                return HttpNotFound();
            }
            return View(paperback);
        }

        // POST: paperbacks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ISBNNumber,Title,Author")] paperback paperback)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paperback).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paperback);
        }

        // GET: paperbacks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            paperback paperback = db.Paperback.Find(id);
            if (paperback == null)
            {
                return HttpNotFound();
            }
            return View(paperback);
        }

        // POST: paperbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            paperback paperback = db.Paperback.Find(id);
            db.Paperback.Remove(paperback);
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
