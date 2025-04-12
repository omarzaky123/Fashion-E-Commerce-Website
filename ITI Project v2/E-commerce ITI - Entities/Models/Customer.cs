using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string BillingAddress { get; set; }

        [Required]
        public string DefaultShippingAddress { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

    }
}
