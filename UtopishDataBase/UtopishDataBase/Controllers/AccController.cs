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
    public class AccController : Controller
    {
        private UtopishDBContext db = new UtopishDBContext();

        // GET: Acc
        public ActionResult Index()
        {
            var account = db.Account.Include(a => a.Archer).Include(a => a.Bank).Include(a => a.Barrack).Include(a => a.Knight).Include(a => a.Lab).Include(a => a.Location).Include(a => a.MountedKnight);
            return View(account.ToList());
        }

        // GET: Acc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account account = db.Account.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        // GET: Acc/Create
        public ActionResult Create()
        {
            ViewBag.ArcherRefID = new SelectList(db.Archer, "ArcherID", "Name");
            ViewBag.BankRefID = new SelectList(db.Bank, "BankID", "BankID");
            ViewBag.BarrackRefID = new SelectList(db.Barrack, "BarrackID", "BarrackID");
            ViewBag.KnightRefID = new SelectList(db.Knight, "KnightID", "Name");
            ViewBag.LabRefID = new SelectList(db.Lab, "LabID", "LabID");
            ViewBag.LocationRefID = new SelectList(db.Location, "LocationID", "LocationID");
            ViewBag.MountedKnightRefID = new SelectList(db.MountedKnight, "MountedKnightID", "Name");
            return View();
        }

        // POST: Acc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccountID,AccountName,AccountPassword,AccountEmail,Power,Size,Gold,LocationRefID,ArcherRefID,KnightRefID,MountedKnightRefID,LabRefID,BankRefID,BarrackRefID")] Account account)
        {
            if (ModelState.IsValid)
            {
                db.Account.Add(account);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArcherRefID = new SelectList(db.Archer, "ArcherID", "Name", account.ArcherRefID);
            ViewBag.BankRefID = new SelectList(db.Bank, "BankID", "BankID", account.BankRefID);
            ViewBag.BarrackRefID = new SelectList(db.Barrack, "BarrackID", "BarrackID", account.BarrackRefID);
            ViewBag.KnightRefID = new SelectList(db.Knight, "KnightID", "Name", account.KnightRefID);
            ViewBag.LabRefID = new SelectList(db.Lab, "LabID", "LabID", account.LabRefID);
            ViewBag.LocationRefID = new SelectList(db.Location, "LocationID", "LocationID", account.LocationRefID);
            ViewBag.MountedKnightRefID = new SelectList(db.MountedKnight, "MountedKnightID", "Name", account.MountedKnightRefID);
            return View(account);
        }

        // GET: Acc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account account = db.Account.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArcherRefID = new SelectList(db.Archer, "ArcherID", "Name", account.ArcherRefID);
            ViewBag.BankRefID = new SelectList(db.Bank, "BankID", "BankID", account.BankRefID);
            ViewBag.BarrackRefID = new SelectList(db.Barrack, "BarrackID", "BarrackID", account.BarrackRefID);
            ViewBag.KnightRefID = new SelectList(db.Knight, "KnightID", "Name", account.KnightRefID);
            ViewBag.LabRefID = new SelectList(db.Lab, "LabID", "LabID", account.LabRefID);
            ViewBag.LocationRefID = new SelectList(db.Location, "LocationID", "LocationID", account.LocationRefID);
            ViewBag.MountedKnightRefID = new SelectList(db.MountedKnight, "MountedKnightID", "Name", account.MountedKnightRefID);
            return View(account);
        }

        // POST: Acc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccountID,AccountName,AccountPassword,AccountEmail,Power,Size,Gold,LocationRefID,ArcherRefID,KnightRefID,MountedKnightRefID,LabRefID,BankRefID,BarrackRefID")] Account account)
        {
            if (ModelState.IsValid)
            {
                db.Entry(account).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArcherRefID = new SelectList(db.Archer, "ArcherID", "Name", account.ArcherRefID);
            ViewBag.BankRefID = new SelectList(db.Bank, "BankID", "BankID", account.BankRefID);
            ViewBag.BarrackRefID = new SelectList(db.Barrack, "BarrackID", "BarrackID", account.BarrackRefID);
            ViewBag.KnightRefID = new SelectList(db.Knight, "KnightID", "Name", account.KnightRefID);
            ViewBag.LabRefID = new SelectList(db.Lab, "LabID", "LabID", account.LabRefID);
            ViewBag.LocationRefID = new SelectList(db.Location, "LocationID", "LocationID", account.LocationRefID);
            ViewBag.MountedKnightRefID = new SelectList(db.MountedKnight, "MountedKnightID", "Name", account.MountedKnightRefID);
            return View(account);
        }

        // GET: Acc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account account = db.Account.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        // POST: Acc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Account account = db.Account.Find(id);
            db.Account.Remove(account);
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
