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
    public class SignupController : ControllerBase
    {
        private readonly SignupRepository<Signup> _signupRepository;

        public SignupController(SignupRepository<Signup> signupRepository)
        {
            _signupRepository = signupRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Signup> signup = _signupRepository.GetAll();
            return Ok(signup);
        }

        [HttpGet("{Email}")]
        public IActionResult Get(string Email)
        {
            Signup signup = _signupRepository.Get(Email);

            if (signup == null)
            {
                return NotFound("The signup record couldn't be found.");
            }

            return Ok(signup);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Signup signup)
        {
            if (signup == null)
            {
                return BadRequest("Signup is null.");
            }

            _signupRepository.Add(signup);
            return Ok(signup);
        }

        [HttpDelete("{Email}")]
        public IActionResult Delete(string Email)
        {
            Signup signup = _signupRepository.Get(Email);
            if (signup == null)
            {
                return NotFound("The Signup record couldn't be found.");
            }

            _signupRepository.Delete(signup);
            return NoContent();
        }


    }
}
