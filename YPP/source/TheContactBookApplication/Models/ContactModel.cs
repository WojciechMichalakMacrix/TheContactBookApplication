using System.ComponentModel.DataAnnotations;

namespace TheContactBookApplication.Models
{
    public class ContactModel : IContactModel
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string StreetName { get; set; } = string.Empty;

        [Required]
        [Range(1, 10000, ErrorMessage = "Provide a proper House Number.")]
        public int HouseNumber { get; set; }

        [Range(1, 10000, ErrorMessage = "Provide a proper Apartment Number.")]
        public int? ApartmentNumber { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Provide Postal Code of format ## - ###.")]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        public string Town { get; set; } = string.Empty;

        [Required]
        [Range(100000000, 999999999, ErrorMessage = "Provide Phone Number that contains 9 digits.")]
        public int PhoneNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

    }
}
