using Microsoft.AspNetCore.Mvc;
using interest_web_api.Models;
using interest_web_api.Data;
using Microsoft.EntityFrameworkCore;

namespace interest_web_api.Controllers
{
    [ApiController]
    [Route("api/household")]
    public class HouseholdController : ControllerBase
    {
        private readonly ILogger<HouseholdController> _logger;
        private readonly InterestDbContext _InterestDbContext;

        public HouseholdController(ILogger<HouseholdController> logger, InterestDbContext context)
        {
            _logger = logger;
            _InterestDbContext = context;
        }


        [HttpGet]
        public IEnumerable<HouseholdInterest> GetHouseholdAll()
        {
            return _InterestDbContext.HouseholdInterestTable
                .AsNoTracking()
                .ToList();
        }


        [HttpGet("{period}")]
        public ActionResult<HouseholdInterest> GetHouseholdByDate(string period)
        {
            var result = _InterestDbContext.HouseholdInterestTable
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
