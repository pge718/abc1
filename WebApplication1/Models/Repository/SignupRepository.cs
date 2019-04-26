using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sulekha.Models.Repository
{
    public interface SignupRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(string Email);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> Login(string email, string Password);
        IEnumerable<TEntity> Forgot(string Email, string Contact_Number);
    }
}
