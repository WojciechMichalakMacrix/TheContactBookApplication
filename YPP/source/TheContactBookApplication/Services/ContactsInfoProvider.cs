using Microsoft.EntityFrameworkCore;
using TheContactBookApplication.Data;
using TheContactBookApplication.Models;

namespace TheContactBookApplication.Services
{
    public class ContactsInfoProvider : IContactsInfoProvider
    {
        private ContactsDbContext contactsDbContext;

        public ContactsInfoProvider(ContactsDbContext contactsDbContext)
        {
            this.contactsDbContext = contactsDbContext;
        }

        public async Task<List<ContactModel>> GetContactsInfoAsync()
        {
            var contacts = await contactsDbContext.ContactModels
                .OrderBy(x => x.Id)
                .ToDictionaryAsync(x => x.Id, x => x);

            var result = new List<ContactModel>();

            foreach (var contact in contacts)
            {
                var model = new ContactModel
                {
                    Id = contact.Value.Id,
                    FirstName = contact.Value.FirstName,
                    LastName = contact.Value.LastName,
                    StreetName = contact.Value.StreetName,
                    HouseNumber = contact.Value.HouseNumber,
                    ApartmentNumber = contact.Value.ApartmentNumber,
                    PostalCode = contact.Value.PostalCode,
                    Town = contact.Value.Town,
                    PhoneNumber = contact.Value.PhoneNumber,
                    DateOfBirth = contact.Value.DateOfBirth
                };

                result.Add(model);
            }

            return result;
        }
    }
}

