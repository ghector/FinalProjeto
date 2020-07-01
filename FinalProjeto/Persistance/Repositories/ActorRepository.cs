using FinalProjeto.Core.Domain;
using FinalProjeto.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjeto.Persistance.Repositories
{
    public class ActorRepository : Repository<Actor>, IActorRepository
    {

        public ActorRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Actor> GetAllFromOneCountry(Country country)
        {
            return Context.Actors.Where(x => x.Country == country).OrderBy(x=>x.LastName);
        }
    }
}