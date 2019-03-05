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
    public class ActorModelsController : Controller
    {
        private MovieWebSiteContext db = new MovieWebSiteContext();

        // GET: ActorModels
        public ActionResult Index()
        {
            return View(db.ActorModels.ToList());
        }

        // GET: ActorModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActorModel actorModel = db.ActorModels.Find(id);
            if (actorModel == null)
            {
                return HttpNotFound();
            }
            return View(actorModel);
        }

        // GET: ActorModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActorModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ActorModelID,ActorName,ActorBio,ActorDOB,ActorRoles")] ActorModel actorModel)
        {
            if (ModelState.IsValid)
            {
                db.ActorModels.Add(actorModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actorModel);
        }

        // GET: ActorModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActorModel actorModel = db.ActorModels.Find(id);
            if (actorModel == null)
            {
                return HttpNotFound();
            }
            return View(actorModel);
        }

        // POST: ActorModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ActorModelID,ActorName,ActorBio,ActorDOB,ActorRoles")] ActorModel actorModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actorModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actorModel);
        }

        // GET: ActorModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActorModel actorModel = db.ActorModels.Find(id);
            if (actorModel == null)
            {
                return HttpNotFound();
            }
            return View(actorModel);
        }

        // POST: ActorModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActorModel actorModel = db.ActorModels.Find(id);
            db.ActorModels.Remove(actorModel);
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
