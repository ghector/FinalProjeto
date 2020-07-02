using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using FinalProjeto.Core.Domain;
using FinalProjeto.Persistance;

namespace FinalProjeto.Controllers.Api
{
    public class MovieApiController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/MovieApi
        public IHttpActionResult GetMovies()
        {
            var movies = db.Movies.Include(x => x.Genre).Include(x => x.Director).ToList();


            //var a = from movie in movies
            //        select new
            //        {
            //            Title = movie.Title,
            //            Rating = movie.Rating,
            //            DirectorsName = string.Format("{0} {1}", movie.Director.FirstName, movie.Director.LastName),
            //            Year = movie.ProductionYear.Year,
            //            Genre = movie.Genre is null ? string.Empty : movie.Genre.Kind,
            //            actors = from actor in movie.Actors
            //                     select new
            //                     {
            //                         FullName = string.Format("{0} {1}",actor.FirstName, actor.LastName),
            //                         salary = actor.Salary,
            //                         photos = from photo in actor.Photos
            //                                  select new
            //                                  {
            //                                      photoUrl = photo.Url
            //                                  }
            //                     }
            //
            //        };

            var a = from movie in movies
                    select new
                    {
                        Title = movie.Title
                    };


            return Ok(a);
        }

        // GET: api/MovieApi/5
        [ResponseType(typeof(Movie))]
        public IHttpActionResult GetMovie(int id)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        // PUT: api/MovieApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMovie(int id, Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != movie.MovieId)
            {
                return BadRequest();
            }

            db.Entry(movie).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/MovieApi
        [ResponseType(typeof(Movie))]
        public IHttpActionResult PostMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Movies.Add(movie);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = movie.MovieId }, movie);
        }

        // DELETE: api/MovieApi/5
        [ResponseType(typeof(Movie))]
        public IHttpActionResult DeleteMovie(int id)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }

            db.Movies.Remove(movie);
            db.SaveChanges();

            return Ok(movie);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MovieExists(int id)
        {
            return db.Movies.Count(e => e.MovieId == id) > 0;
        }
    }
}