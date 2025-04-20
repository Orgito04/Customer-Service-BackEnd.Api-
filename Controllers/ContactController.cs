using Microsoft.AspNetCore.Mvc;
using CustomerServiceBackend.Data;
using CustomerServiceBackend.Models;

namespace CustomerServiceBackend.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context) {
            _context = context;
        }

        [HttpPost("send")]
        public IActionResult SendContact(ContactRequest request) {
            _context.ContactRequests.Add(request);
            _context.SaveChanges();
            return Ok(request);
        }
    }
}