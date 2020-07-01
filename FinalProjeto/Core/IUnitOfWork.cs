using FinalProjeto.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjeto.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IActorRepository Actors { get; }
        IDirectorRepository Directors { get; }
        IGenreRepository Genres { get; }
        IPhotoRepository Photos { get; }
        IMovieRepository Movies { get; }


        int Complete();

    }
}