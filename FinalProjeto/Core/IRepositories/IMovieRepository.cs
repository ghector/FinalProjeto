﻿using FinalProjeto.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjeto.Core.IRepositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IEnumerable<Movie> GetAll(int numberOfMovies);
    }
}