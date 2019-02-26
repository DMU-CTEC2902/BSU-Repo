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
    public class FilmModelsController : Controller
    {
        private MovieWebSiteContext db = new MovieWebSiteContext();

        // GET: FilmModels
        public ActionResult Index()
        {
            return View(db.FilmModels.ToList());
        }

        // GET: FilmModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilmModel filmModel = db.FilmModels.Find(id);
            if (filmModel == null)
            {
                return HttpNotFound();
            }
            return View(filmModel);
        }

        // GET: FilmModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmModelID,FilmName,FilmDescription,ReleaseDate,FilmLength,GenreId,Genre")] FilmModel filmModel)
        {
            if (ModelState.IsValid)
            {
                db.FilmModels.Add(filmModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(filmModel);
        }

        // GET: FilmModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilmModel filmModel = db.FilmModels.Find(id);
            if (filmModel == null)
            {
                return HttpNotFound();
            }
            return View(filmModel);
        }

        // POST: FilmModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmModelID,FilmName,FilmDescription,ReleaseDate,FilmLength,GenreId,Genre")] FilmModel filmModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filmModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filmModel);
        }

        // GET: FilmModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilmModel filmModel = db.FilmModels.Find(id);
            if (filmModel == null)
            {
                return HttpNotFound();
            }
            return View(filmModel);
        }

        // POST: FilmModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FilmModel filmModel = db.FilmModels.Find(id);
            db.FilmModels.Remove(filmModel);
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
