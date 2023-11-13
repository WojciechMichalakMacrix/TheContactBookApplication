namespace TheContactBookApplication.Models
{
    public class ContactModel : IContactModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string StreetName { get; set; } = string.Empty;

        public int HouseNumber { get; set; }

        public int? ApartmentNumber { get; set; }

        public string PostalCode { get; set; } = string.Empty;

        public string Town { get; set; } = string.Empty;

        public int PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public IList<ContactModelProperties> Properties { get; set; } = new List<ContactModelProperties>();

    }
}
