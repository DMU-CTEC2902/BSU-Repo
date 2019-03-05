using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieWebSite.Models;

namespace MovieWebSite.Controllers
{
    public class DirectorModelsController : Controller
    {
        private MovieWebSiteContext db = new MovieWebSiteContext();

        // GET: DirectorModels
        public ActionResult Index()
        {
            return View(db.DirectorModels.ToList());
        }

        // GET: DirectorModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DirectorModel directorModel = db.DirectorModels.Find(id);
            if (directorModel == null)
            {
                return HttpNotFound();
            }
            return View(directorModel);
        }

        // GET: DirectorModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DirectorModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DirectorModelID,DirectorName,DirectorBio,DirectorDOB")] DirectorModel directorModel)
        {
            if (ModelState.IsValid)
            {
                db.DirectorModels.Add(directorModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(directorModel);
        }

        // GET: DirectorModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DirectorModel directorModel = db.DirectorModels.Find(id);
            if (directorModel == null)
            {
                return HttpNotFound();
            }
            return View(directorModel);
        }

        // POST: DirectorModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DirectorModelID,DirectorName,DirectorBio,DirectorDOB")] DirectorModel directorModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(directorModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(directorModel);
        }

        // GET: DirectorModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DirectorModel directorModel = db.DirectorModels.Find(id);
            if (directorModel == null)
            {
                return HttpNotFound();
            }
            return View(directorModel);
        }

        // POST: DirectorModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DirectorModel directorModel = db.DirectorModels.Find(id);
            db.DirectorModels.Remove(directorModel);
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
