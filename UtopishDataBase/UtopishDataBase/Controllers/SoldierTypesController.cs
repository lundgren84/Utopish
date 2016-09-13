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
    public class SoldierTypesController : Controller
    {
        private UtopishDBContext db = new UtopishDBContext();

        // GET: SoldierTypes
        public ActionResult Index()
        {
            return View(db.SoldierType.ToList());
        }

        // GET: SoldierTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SoldierType soldierType = db.SoldierType.Find(id);
            if (soldierType == null)
            {
                return HttpNotFound();
            }
            return View(soldierType);
        }

        // GET: SoldierTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SoldierTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SoldierTypeID,SoldierTypeName")] SoldierType soldierType)
        {
            if (ModelState.IsValid)
            {
                db.SoldierType.Add(soldierType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(soldierType);
        }

        // GET: SoldierTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SoldierType soldierType = db.SoldierType.Find(id);
            if (soldierType == null)
            {
                return HttpNotFound();
            }
            return View(soldierType);
        }

        // POST: SoldierTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SoldierTypeID,SoldierTypeName")] SoldierType soldierType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(soldierType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(soldierType);
        }

        // GET: SoldierTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SoldierType soldierType = db.SoldierType.Find(id);
            if (soldierType == null)
            {
                return HttpNotFound();
            }
            return View(soldierType);
        }

        // POST: SoldierTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SoldierType soldierType = db.SoldierType.Find(id);
            db.SoldierType.Remove(soldierType);
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
