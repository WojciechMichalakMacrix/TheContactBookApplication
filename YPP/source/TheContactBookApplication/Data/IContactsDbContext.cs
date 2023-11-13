using Microsoft.EntityFrameworkCore;
using TheContactBookApplication.Models;

namespace TheContactBookApplication.Data
{
    public interface IContactsDbContext
    {
        DbSet<ContactModel> ContactModels { get; set; }
    }
}
