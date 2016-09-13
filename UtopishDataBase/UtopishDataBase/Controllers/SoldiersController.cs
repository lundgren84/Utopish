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
    public class SoldiersController : Controller
    {
        private UtopishDBContext db = new UtopishDBContext();

        // GET: Soldiers
        public ActionResult Index()
        {
            var soldier = db.Soldier.Include(s => s.CauseType);
            return View(soldier.ToList());
        }

        // GET: Soldiers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soldier soldier = db.Soldier.Find(id);
            if (soldier == null)
            {
                return HttpNotFound();
            }
            return View(soldier);
        }

        // GET: Soldiers/Create
        public ActionResult Create()
        {
            ViewBag.SoldierTypeRefID = new SelectList(db.SoldierType, "SoldierTypeID", "SoldierTypeName");
            return View();
        }

        // POST: Soldiers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SoldierID,SoldierTypeRefID")] Soldier soldier)
        {
            if (ModelState.IsValid)
            {
                db.Soldier.Add(soldier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SoldierTypeRefID = new SelectList(db.SoldierType, "SoldierTypeID", "SoldierTypeName", soldier.SoldierTypeRefID);
            return View(soldier);
        }

        // GET: Soldiers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soldier soldier = db.Soldier.Find(id);
            if (soldier == null)
            {
                return HttpNotFound();
            }
            ViewBag.SoldierTypeRefID = new SelectList(db.SoldierType, "SoldierTypeID", "SoldierTypeName", soldier.SoldierTypeRefID);
            return View(soldier);
        }

        // POST: Soldiers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SoldierID,SoldierTypeRefID")] Soldier soldier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(soldier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SoldierTypeRefID = new SelectList(db.SoldierType, "SoldierTypeID", "SoldierTypeName", soldier.SoldierTypeRefID);
            return View(soldier);
        }

        // GET: Soldiers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soldier soldier = db.Soldier.Find(id);
            if (soldier == null)
            {
                return HttpNotFound();
            }
            return View(soldier);
        }

        // POST: Soldiers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Soldier soldier = db.Soldier.Find(id);
            db.Soldier.Remove(soldier);
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
