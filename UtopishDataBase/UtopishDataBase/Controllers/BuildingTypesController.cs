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
    public class BuildingTypesController : Controller
    {
        private UtopishDBContext db = new UtopishDBContext();

        // GET: BuildingTypes
        public ActionResult Index()
        {
            return View(db.BuildingType.ToList());
        }

        // GET: BuildingTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuildingType buildingType = db.BuildingType.Find(id);
            if (buildingType == null)
            {
                return HttpNotFound();
            }
            return View(buildingType);
        }

        // GET: BuildingTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BuildingTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BuildingTypeID,BuildingTypeName")] BuildingType buildingType)
        {
            if (ModelState.IsValid)
            {
                db.BuildingType.Add(buildingType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(buildingType);
        }

        // GET: BuildingTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuildingType buildingType = db.BuildingType.Find(id);
            if (buildingType == null)
            {
                return HttpNotFound();
            }
            return View(buildingType);
        }

        // POST: BuildingTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BuildingTypeID,BuildingTypeName")] BuildingType buildingType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(buildingType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(buildingType);
        }

        // GET: BuildingTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuildingType buildingType = db.BuildingType.Find(id);
            if (buildingType == null)
            {
                return HttpNotFound();
            }
            return View(buildingType);
        }

        // POST: BuildingTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BuildingType buildingType = db.BuildingType.Find(id);
            db.BuildingType.Remove(buildingType);
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
