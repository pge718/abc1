using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sulekha.Models.Repository
{
    public interface DoctorRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(string TypeName);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }
}
