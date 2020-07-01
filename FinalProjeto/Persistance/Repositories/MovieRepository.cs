using FinalProjeto.Core.Domain;
using FinalProjeto.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjeto.Persistance.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {

        public MovieRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Movie> GetAll(int numberOfMovies)
        {
            return Context.Movies.Take(numberOfMovies).ToList();
        }

        public IEnumerable<Movie> GetTopMoviesByGenre(string genreKind)
        {
            return Context.Movies.Where(x => x.Genre.Kind == genreKind).OrderByDescending(x => x.Rating).ToList();
        }

        public IEnumerable<Movie> GetTopMoviesByGenre(string genreKind, int count)
        {
            return Context.Movies.Where(x => x.Genre.Kind == genreKind).OrderByDescending(x => x.Rating).Take(count).ToList();
        }
    }
}