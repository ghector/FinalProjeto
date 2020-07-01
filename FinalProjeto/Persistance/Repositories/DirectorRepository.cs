using FinalProjeto.Core.Domain;
using FinalProjeto.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjeto.Persistance.Repositories
{
    public class DirectorRepository : Repository<Director>, IDirectorRepository
    {

        public DirectorRepository(ApplicationDbContext context) : base(context)
        {

        }





    }
}