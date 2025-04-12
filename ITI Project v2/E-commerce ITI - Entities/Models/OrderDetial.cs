using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace Models
{
    public class OrderDetial
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Order")]

        public int? OrderId { get; set; }

        public Order Order { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }


        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Sku { get; set; }

        [Required]
        public int Quantity { get; set; }

    }
}
