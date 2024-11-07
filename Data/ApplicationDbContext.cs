using CologneStore.Models;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CologneStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cologne> Colognes { get; set; }
        public DbSet<CologneType> Types { get; set; }
        public DbSet<CologneFor> ColognesFor { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyRegistration> CompanyRegistrations { get; set; }
    }
}
