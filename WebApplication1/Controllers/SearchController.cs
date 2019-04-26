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
    public class SearchController : ControllerBase
    {
        private readonly BusinessRepository<Business> _businessRepository;

        public SearchController(BusinessRepository<Business> businessRepository)
        {
            _businessRepository = businessRepository;
        }

       /* [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Business> business = _businessRepository.GetAll();
            return Ok(business);
        } */
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IEnumerable<Business> result = _businessRepository.Search(id);
            return Ok(result);
        }
    }
}
