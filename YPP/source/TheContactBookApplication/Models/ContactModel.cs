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
        public int HouseNumber { get; set; }

        public int? ApartmentNumber { get; set; }

        [Required]
        [StringLength(6, ErrorMessage = "Provide PostalCode of format ## - ###.")]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        public string Town { get; set; } = string.Empty;

        [Required]
        [Range(100000000, 999999999, ErrorMessage = "Provide PhoneNumber that contains 9 digits.")]
        public int PhoneNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

    }
}
