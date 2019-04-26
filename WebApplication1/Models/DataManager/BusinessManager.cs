using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sulekha.Models.Repository;
using Microsoft.EntityFrameworkCore;


namespace Sulekha.Models.DataManager
{
    public class BusinessManager : BusinessRepository<Business>
    {
        readonly Context _businessContext;

        public BusinessManager(Context context)
        {
            _businessContext = context;
        }

        public IEnumerable<Business> GetByTypeName(string category)
        {
            var query_res = from doc in _businessContext.Doctor
                            join busi in _businessContext.Business

                            on doc.TypeName equals busi.SubService_name
                            where doc.TypeName == category
                            select busi;

            return query_res.ToList();
        }

        public Business Get(int Business_ID)
        {
            return _businessContext.Business
                  .FirstOrDefault(e => e.Business_ID == Business_ID);
        }

        public void Add(Business business)
        {
            _businessContext.Business.Add(business);
            _businessContext.SaveChanges();
        }

        public void Update(Business employee, Business entity)
        {
            employee.Address = entity.Address;
            employee.Information = entity.Information;
            employee.PhoneNumber = entity.PhoneNumber;
           
            employee.SubService_name = entity.SubService_name;
            employee.Service_name = entity.Service_name;

            _businessContext.SaveChanges();
        }

        public void Delete(Business employee)
        {
            _businessContext.Business.Remove(employee);
            _businessContext.SaveChanges();
        }

        public IEnumerable<Business> Search(int id)
        {
            var result = from p in _businessContext.Business
                         where p.Business_ID == id
                         select p;
            return result;
        }

        public IEnumerable<Business> Filter(string service_name)
        {
            var result = from p in _businessContext.Business
                         where (p.Service_name == service_name) 
                         select p;
            return result;
        }

        public IEnumerable<Business> SearchByName(string name)
        {
            var result = from p in _businessContext.Business
                         where p.Name == name
                         select p;
            return result;
        }

        
    }
}
