
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjeto.Core.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int? id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Edit(TEntity entity);
        void Remove(TEntity entity);

    }
}