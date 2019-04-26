using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sulekha.Models.Repository
{
    public interface BusinessRepository<TEntity>
    {
        IEnumerable<TEntity> GetByTypeName(string category);
        TEntity Get(int Business_ID);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> Search(int id);
        IEnumerable<TEntity> Filter(string Service_name);
        IEnumerable<TEntity> SearchByName(string name);
    }
}
