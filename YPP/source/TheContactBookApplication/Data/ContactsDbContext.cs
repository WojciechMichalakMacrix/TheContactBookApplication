using Microsoft.EntityFrameworkCore;
using TheContactBookApplication.Components;
using TheContactBookApplication.Models;

namespace TheContactBookApplication.Data
{
    public class ContactsDbContext : DbContext, IContactsDbContext
    {
        protected readonly IConfiguration Configuration;

        public ContactsDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DBConnectionString"));
        }
        public DbSet<ContactModel> ContactModels { get; set; }
    }
}
