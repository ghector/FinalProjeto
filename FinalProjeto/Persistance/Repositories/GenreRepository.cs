using FinalProjeto.Core.Domain;
using FinalProjeto.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjeto.Persistance.Repositories
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {

        public GenreRepository(ApplicationDbContext context) : base(context)
        {

        }





    }
}