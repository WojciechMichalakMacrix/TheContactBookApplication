using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TheContactBookApplication.Components;
using TheContactBookApplication.Models;

namespace TheContactBookApplication.Data
{
    public class ContactsDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ContactsDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DBConnectionString"));
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        public DbSet<ContactModel> ContactModels { get; set; }
    }
}
