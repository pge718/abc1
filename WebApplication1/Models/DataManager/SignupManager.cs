using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sulekha.Models.Repository;

namespace Sulekha.Models.DataManager
{
    public class SignupManager : SignupRepository<Signup>
    {
        readonly Context _signupContext;

        public SignupManager(Context context)
        {
            _signupContext = context;
        }


        public IEnumerable<Signup> GetAll()
        {
            return _signupContext.Signup.ToList();
        }

        public Signup Get(string Email)
        {
            return _signupContext.Signup
                  .FirstOrDefault(e => e.Email == Email);
        }


        public void Add(Signup signup)
        {
            _signupContext.Signup.Add(signup);
            _signupContext.SaveChanges();
        }

        public void Update(Signup employee, Signup entity)
        {
            employee.FirstName = entity.FirstName;
            employee.LastName = entity.LastName;
            employee.Contact_Number = entity.Contact_Number;
            employee.Email = entity.Email;
            employee.password = entity.password;
            employee.retypePassword = entity.retypePassword;
            employee.Role = entity.Role;

            _signupContext.SaveChanges();
        }

        public void Delete(Signup signup)
        {
            _signupContext.Signup.Remove(signup);
            _signupContext.SaveChanges();
        }

        public IEnumerable<Signup> Login(string email,string Password) { 
            
            var result = _signupContext.Signup.Where(m => m.Email == email && m.password == Password);
            return result;
        }

        public IEnumerable<Signup> Forgot(string email, string Contact_Number)
        {
            var result = from p in _signupContext.Signup
                         where p.Email == email && p.Contact_Number == Contact_Number
                         select p;
            return result;
        }

    }
}
