namespace TheContactBookApplication.Models
{
    public interface IContactModel
    {
        int Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string StreetName { get; set; }

        int HouseNumber { get; set; }

        int? ApartmentNumber { get; set; }

        string PostalCode { get; set; }

        string Town { get; set; }

        int PhoneNumber { get; set; }

        DateTime DateOfBirth { get; set; }
    }
}
