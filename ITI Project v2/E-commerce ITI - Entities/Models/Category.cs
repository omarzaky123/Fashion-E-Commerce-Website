using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class Category
	{
		#region Attributes

		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public string Thumbnail { get; set; }
		#endregion

		#region Relations
		public virtual List<Product>? Products { get; set; }
		#endregion

	}
}
