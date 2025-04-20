using Microsoft.EntityFrameworkCore;
using CustomerServiceBackend.Models;

namespace CustomerServiceBackend.Data {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<ContactRequest> ContactRequests { get; set; }
        public DbSet<PricingPlan> PricingPlans { get; set; }
    }
}