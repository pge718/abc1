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
    public class BusinessController : ControllerBase
    {
        private readonly BusinessRepository<Business> _businessRepository;


        public BusinessController(BusinessRepository<Business> businessRepository)
        {
            _businessRepository = businessRepository;
        }

        


        [HttpGet("{Business_ID}")]
        public IActionResult Get(int Business_ID)
        {
            Business business = _businessRepository.Get(Business_ID);

           if (business == null)
           {
               return NotFound("The Business record couldn't be found.");
           }

           return Ok(business);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Business business)
        {
            if (business == null)
            {
                return BadRequest("Employee is null.");
            }

            _businessRepository.Add(business);
            return CreatedAtRoute(
                  "Get",
                  new { Business_Id = business.Business_ID },
                  business);
        }



        [HttpDelete("{Business_ID}")]
        public IActionResult Delete(int Business_ID)
        {
            Business business = _businessRepository.Get(Business_ID);
            if (business == null)
            {
                return NotFound("The Business record couldn't be found.");
            }

            _businessRepository.Delete(business);
            return NoContent();
        }

        /*[HttpGet("{phoneNumber}")]
        public IActionResult Get(string phoneNumber)
        {
            IEnumerable<Business> result = _businessRepository.Search(phoneNumber);
            return Ok(result);
        }*/
        
    }
}
