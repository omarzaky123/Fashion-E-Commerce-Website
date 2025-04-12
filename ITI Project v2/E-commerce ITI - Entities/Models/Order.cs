using Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [ForeignKey("Customer")]

        public int? CustomerId { get; set; }

        public Customer Customer { get; set; }

        [Required]
        public decimal Ammount {  get; set; }
        [Required]
        public string ShippingAddress { get; set; }

        [Required]
        public string OrderAddress { get; set; }

        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public DateOnly OrderDate { get; set; }

        [Required]
        public bool OrderStatus { get; set; }
    }
}
