using FinalProjeto.Core;
using FinalProjeto.Core.IRepositories;
using FinalProjeto.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjeto.Persistance
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;


        public IActorRepository Actors { get; private set; }
        public IDirectorRepository Directors { get; private set; }
        public IGenreRepository Genres { get; private set; }
        public IPhotoRepository Photos { get; private set; }
        public IMovieRepository Movies { get; private set; }



        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Actors = new ActorRepository(_context);
            Directors = new DirectorRepository(_context);
            Genres = new GenreRepository(_context);
            Photos = new PhotoRepository(_context);
            Movies = new MovieRepository(_context);
        }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}