using Microsoft.EntityFrameworkCore;
using TheContactBookApplication.Data;
using TheContactBookApplication.Models;

namespace TheContactBookApplication.Services
{
    public class ContactsInfoProvider : IContactsInfoProvider
    {
        private IContactsDbContext contactsDbContext;

        public ContactsInfoProvider(IContactsDbContext contactsDbContext)
        {
            this.contactsDbContext = contactsDbContext;
        }

        public async Task<List<ContactModel>> GetContactsInfoAsync()
        {
            var contacts = await contactsDbContext.ContactModels
                .OrderByDescending(x => x.Id)
                .ToDictionaryAsync(x => x);

            var result = new List<ContactModel>();

            foreach (var contact in contacts)
            {
                //ContactModelProperties[] properties;

                //properties = new ContactModelProperties[]
                //{
                //    new ContactModelProperties("First Name", contact.Value.FirstName),
                //    new ContactModelProperties("Last Name", contact.Value.LastName),
                //    new ContactModelProperties("Street Name", contact.Value.StreetName),
                //    new ContactModelProperties("House Number", contact.Value.HouseNumber),
                //    new ContactModelProperties("Apartment Number", contact.Value.ApartmentNumber),
                //    new ContactModelProperties("Postal Code", contact.Value.PostalCode),
                //    new ContactModelProperties("Town", contact.Value.Town),
                //    new ContactModelProperties("Phone Number", contact.Value.PhoneNumber),
                //    new ContactModelProperties("Date Of Birth", contact.Value.DateOfBirth)
                //};

                var model = new ContactModel
                {
                    Id = contact.Value.Id,
                    FirstName = contact.Value.FirstName,
                    LastName = contact.Value.LastName,
                    StreetName = contact.Value.StreetName,
                    HouseNumber = contact.Value.HouseNumber,
                    ApartmentNumber = contact.Value.HouseNumber,
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

