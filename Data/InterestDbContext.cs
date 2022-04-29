using Microsoft.EntityFrameworkCore;
using interest_web_api.Models;

namespace interest_web_api.Data
{
    public class InterestDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Database=<db>; " +
                "Host=<host>; " +
                "User Id=<id>; " +
                "Password=<pass>; " +
                "SSL Mode=<ssl>; " +
                "Trust Server Certificate=<trust>");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("interest_rates_schema");
        }

        public InterestDbContext(DbContextOptions<InterestDbContext> options) : base(options)
        {
        }


        public DbSet<CorporationInterest> CorporationInterestTable => Set<CorporationInterest>();
        public DbSet<HouseholdInterest> HouseholdInterestTable => Set<HouseholdInterest>();
    }
}