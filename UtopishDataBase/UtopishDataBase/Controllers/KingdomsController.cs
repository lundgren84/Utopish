using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UtopishDataBase;

namespace UtopishDataBase.Controllers
{
    public class KingdomsController : Controller
    {
        private UtopishDBContext db = new UtopishDBContext();

        // GET: Kingdoms
        public ActionResult Index()
        {
            return View(db.Kingdom.ToList());
        }

        // GET: Kingdoms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kingdom kingdom = db.Kingdom.Find(id);
            if (kingdom == null)
            {
                return HttpNotFound();
            }
            return View(kingdom);
        }

        // GET: Kingdoms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kingdoms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KingdomID,KingdomName,gold,stone,wood")] Kingdom kingdom)
        {
            if (ModelState.IsValid)
            {
                db.Kingdom.Add(kingdom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kingdom);
        }

        // GET: Kingdoms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kingdom kingdom = db.Kingdom.Find(id);
            if (kingdom == null)
            {
                return HttpNotFound();
            }
            return View(kingdom);
        }

        // POST: Kingdoms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KingdomID,KingdomName,gold,stone,wood")] Kingdom kingdom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kingdom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kingdom);
        }

        // GET: Kingdoms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kingdom kingdom = db.Kingdom.Find(id);
            if (kingdom == null)
            {
                return HttpNotFound();
            }
            return View(kingdom);
        }

        // POST: Kingdoms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kingdom kingdom = db.Kingdom.Find(id);
            db.Kingdom.Remove(kingdom);
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
