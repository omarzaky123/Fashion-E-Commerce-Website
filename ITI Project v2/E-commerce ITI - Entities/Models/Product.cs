using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Models
{
	public class Product
	{
		#region Attributes
		[Key]
		public int Id { get; set; }

		[Required]
		public string Sku { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]

		[Column(TypeName = "Money")]
		public decimal Price { get; set; }

		[Required]
		public int Weight { get; set; }

		[Required]
		public string Descripition { get; set; }

		[Required]
		public string Thumbnail { get; set; }

		[Required]
		public string Image { get; set; }

		[Required]

		[Column(TypeName = "Date")]
		public DateTime CreateDate { get; set; }

		[Required]
		public int Stock { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        #endregion
        #region Relations
        public virtual Category? Category { get; set; }	
		#endregion

	}
}
