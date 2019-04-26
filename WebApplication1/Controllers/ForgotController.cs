using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sulekha.Models.Repository;
using Sulekha.Models;

namespace Sulekha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForgotController : ControllerBase
    {
        private readonly SignupRepository<Signup> _signupRepository;

        public ForgotController(SignupRepository<Signup> signupRepository)
        {
            _signupRepository = signupRepository;
        }

        /* [HttpGet]
         public IActionResult Get()
         {
             IEnumerable<Business> business = _businessRepository.GetAll();
             return Ok(business);
         } */
        [HttpGet("{Email}/{Contact_Number}")]
        public IActionResult Get(string email, string Contact_Number)
        {
            IEnumerable<Signup> result = _signupRepository.Forgot(email, Contact_Number);
            return Ok(result);
        }
    }
}
