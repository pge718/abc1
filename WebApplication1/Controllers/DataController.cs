using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sulekha.Models;
using Sulekha.Models.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sulekha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class DataController : ControllerBase
    {
        private readonly BusinessRepository<Business> _businessRepository;

        public DataController(BusinessRepository<Business> businessRepository)
        {
            _businessRepository = businessRepository;
        }


        [HttpPost]
        public IActionResult Get([FromBody] CategoryOnly category)
        {
            var business = _businessRepository.GetByTypeName(category.category);
            return Ok(business);
        }
    }

    public class CategoryOnly
    {
        public string category { get; set; }
    }
}
