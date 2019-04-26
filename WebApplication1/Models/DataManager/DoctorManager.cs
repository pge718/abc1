using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sulekha.Models.Repository;

namespace Sulekha.Models.DataManager
{
    public class DoctorManager : DoctorRepository<Doctor>
    {
        readonly Context _doctorContext;

        public DoctorManager(Context context)
        {
            _doctorContext = context;
        }

        public IEnumerable<Doctor> GetAll()
        {
            return _doctorContext.Doctor.ToList();
        }
        public void Update(Doctor dbEntity, Doctor entity) { }

        public Doctor Get(string TypeName)
        {
            return _doctorContext.Doctor
                  .FirstOrDefault(e => e.TypeName == TypeName);
        }

        public void Add(Doctor doctor)
        {
            _doctorContext.Doctor.Add(doctor);
            _doctorContext.SaveChanges();
        }



        public void Delete(Doctor doctor)
        {
            _doctorContext.Doctor.Remove(doctor);
            _doctorContext.SaveChanges();
        }


    }
}
