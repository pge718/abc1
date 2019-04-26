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
    public class SearchByNameController : ControllerBase
    {
        private readonly BusinessRepository<Business> _businessRepository;

        public SearchByNameController(BusinessRepository<Business> businessRepository)
        {
            _businessRepository = businessRepository;
        }

        
        [HttpGet("{Name}")]
        public IActionResult Get(string name)
        {
            IEnumerable<Business> result = _businessRepository.SearchByName(name);
            return Ok(result);
        }
    }
}
