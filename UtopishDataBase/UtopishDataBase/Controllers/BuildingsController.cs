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
    public class BuildingsController : Controller
    {
        private UtopishDBContext db = new UtopishDBContext();

        // GET: Buildings
        public ActionResult Index()
        {
            var building = db.Building.Include(b => b.BuildingType);
            return View(building.ToList());
        }

        // GET: Buildings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Building building = db.Building.Find(id);
            if (building == null)
            {
                return HttpNotFound();
            }
            return View(building);
        }

        // GET: Buildings/Create
        public ActionResult Create()
        {
            ViewBag.BuildingTypeRefID = new SelectList(db.BuildingType, "BuildingTypeID", "BuildingTypeName");
            return View();
        }

        // POST: Buildings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BuildingID,BuildingTypeRefID")] Building building)
        {
            if (ModelState.IsValid)
            {
                db.Building.Add(building);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BuildingTypeRefID = new SelectList(db.BuildingType, "BuildingTypeID", "BuildingTypeName", building.BuildingTypeRefID);
            return View(building);
        }

        // GET: Buildings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Building building = db.Building.Find(id);
            if (building == null)
            {
                return HttpNotFound();
            }
            ViewBag.BuildingTypeRefID = new SelectList(db.BuildingType, "BuildingTypeID", "BuildingTypeName", building.BuildingTypeRefID);
            return View(building);
        }

        // POST: Buildings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BuildingID,BuildingTypeRefID")] Building building)
        {
            if (ModelState.IsValid)
            {
                db.Entry(building).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BuildingTypeRefID = new SelectList(db.BuildingType, "BuildingTypeID", "BuildingTypeName", building.BuildingTypeRefID);
            return View(building);
        }

        // GET: Buildings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Building building = db.Building.Find(id);
            if (building == null)
            {
                return HttpNotFound();
            }
            return View(building);
        }

        // POST: Buildings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Building building = db.Building.Find(id);
            db.Building.Remove(building);
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
