using Microsoft.AspNetCore.Mvc;
using interest_web_api.Models;
using interest_web_api.Data;
using Microsoft.EntityFrameworkCore;

namespace interest_web_api.Controllers
{
    [ApiController]
    [Route("api/corporation")]
    public class CorporationController : ControllerBase
    {
        private readonly ILogger<CorporationController> _logger;
        private readonly InterestDbContext _InterestDbContext;

        public CorporationController(ILogger<CorporationController> logger, InterestDbContext context)
        {
            _logger = logger;
            _InterestDbContext = context;
        }


        [HttpGet]
        public IEnumerable<CorporationInterest> GetCorporationAll()
        {            
            return _InterestDbContext.CorporationInterestTable
                .AsNoTracking()
                .ToList();           
        }

        
        [HttpGet("{period}")]
        public ActionResult<CorporationInterest> GetCorporationByDate(string period)
        {
            var result = _InterestDbContext.CorporationInterestTable
                .AsNoTracking()
                .SingleOrDefault(p => p.Period == period);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}
