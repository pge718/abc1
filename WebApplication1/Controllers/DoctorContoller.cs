using System;
using System.Collections.Generic;
using Sulekha.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sulekha.Models.Repository;

namespace Sulekha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorRepository<Doctor> _doctorRepository;

        public DoctorController(DoctorRepository<Doctor> doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var  doctor = _doctorRepository.GetAll();
            return Ok(doctor);
        }

        [HttpGet("{TypeName}")]
        public IActionResult Get(string TypeName)
        {
            Doctor doctor = _doctorRepository.Get(TypeName);
            return Ok(doctor);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Doctor doctor)
        {
            if (doctor == null)
            {
                return BadRequest("doctor is null.");
            }

            _doctorRepository.Add(doctor);
            return CreatedAtRoute(
                  "Get",
                  new { TypeName = doctor.TypeName },
                  doctor);
        }

        [HttpDelete("{TypeName}")]
        public IActionResult Delete(string TypeName)
        {
            Doctor doctor = _doctorRepository.Get(TypeName);
            if (doctor == null)
            {
                return NotFound("The doctor record couldn't be found.");
            }

            _doctorRepository.Delete(doctor);
            return NoContent();
        }
    }
}
