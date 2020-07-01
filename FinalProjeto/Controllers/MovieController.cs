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
    public class MovieController : Controller
    {
        UnitOfWork db = new UnitOfWork(new ApplicationDbContext());


        // GET: Movie/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Get(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
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
