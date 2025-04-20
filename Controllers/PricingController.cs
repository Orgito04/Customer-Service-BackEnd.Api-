using Microsoft.AspNetCore.Mvc;
using CustomerServiceBackend.Data;

namespace CustomerServiceBackend.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class PricingController : ControllerBase {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPlans() {
            return Ok(_context.PricingPlans.ToList());
        }
    }
}