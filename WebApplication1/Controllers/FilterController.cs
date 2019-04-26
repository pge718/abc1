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
    public class FilterController : ControllerBase
    {
        private readonly BusinessRepository<Business> _businessRepository;

        public FilterController(BusinessRepository<Business> businessRepository)
        {
            _businessRepository = businessRepository;
        }

        
        [HttpGet("{Service_name}")]
        public IActionResult Get(string Service_name)
        {
            IEnumerable<Business> result = _businessRepository.Filter(Service_name);
            return Ok(result);
        }
    }
}