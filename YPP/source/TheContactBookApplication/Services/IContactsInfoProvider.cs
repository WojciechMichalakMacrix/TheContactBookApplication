using TheContactBookApplication.Models;

namespace TheContactBookApplication.Services
{
    public interface IContactsInfoProvider
    {
        Task<List<ContactModel>> GetContactsInfoAsync();
    }
}

