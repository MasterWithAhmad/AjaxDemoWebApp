using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        // Primary key for the Contact entity
        public int Id { get; set; }

        // Name of the contact. Required field with a maximum length of 100 characters.
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = "";


        // Phone number of the contact. Required field with validation for phone number format.
        [Required]
        [Phone]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; } = "";


        // Email address of the contact. Required field with validation for email format.
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";


        // Address of the contact. Optional field with a maximum length of 200 characters.
        [StringLength(200)]
        public string Address { get; set; } = "";
    }
}
