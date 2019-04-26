using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sulekha.Models;
using Sulekha.Models.Repository;

namespace Sulekha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly SignupRepository<Signup> _signupRepository;

        public LoginController(SignupRepository<Signup> signupRepository)
        {
            _signupRepository = signupRepository;
        }

        //[HttpGet("{Email}/{password}")]
        //public IActionResult Get(string Email,string password)
        //{
        //    IEnumerable<Signup> result = _signupRepository.Login(Email, password);
        //    return Ok(result);
        //}

        [HttpPost]
        public ActionResult Post([FromBody] UserDetail login)
        {

            var emailget = _signupRepository.Login(login.email, login.password);

            if(emailget == null)
            {
                return NotFound();
            }

            return Ok(emailget);
            
        }
    }

    public class UserDetail
    {
        public string email { get; set; }
        public string password { get; set; }
        
    }
}
