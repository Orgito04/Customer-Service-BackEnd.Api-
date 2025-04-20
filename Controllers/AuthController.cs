using Microsoft.AspNetCore.Mvc;
using CustomerServiceBackend.Data;
using CustomerServiceBackend.Models;

namespace CustomerServiceBackend.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context) {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Register(User user) {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }
    }
}