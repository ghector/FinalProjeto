using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProjeto.Core.Domain;
using FinalProjeto.Persistance;

namespace FinalProjeto.Controllers
{
    [Authorize]
    public class ManageMovieController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ManageMovie
        public ActionResult Index()
        {
            var movies = db.Movies.Include(m => m.Director).Include(m => m.Genre);
            return View(movies.ToList());
        }

        // GET: ManageMovie/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: ManageMovie/Create
        public ActionResult Create()
        {
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "FirstName");
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Kind");
            return View();
        }

        // POST: ManageMovie/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieId,Title,Rating,Country,ProductionYear,Duration,PhotoUrl,TrailerUrl,Price,Watched,DirectorId,GenreId")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "FirstName", movie.DirectorId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Kind", movie.GenreId);
            return View(movie);
        }

        // GET: ManageMovie/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "FirstName", movie.DirectorId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Kind", movie.GenreId);
            return View(movie);
        }

        // POST: ManageMovie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieId,Title,Rating,Country,ProductionYear,Duration,PhotoUrl,TrailerUrl,Price,Watched,DirectorId,GenreId")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "FirstName", movie.DirectorId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Kind", movie.GenreId);
            return View(movie);
        }

        // GET: ManageMovie/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: ManageMovie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
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
