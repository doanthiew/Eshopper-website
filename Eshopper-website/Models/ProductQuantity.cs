using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshopper_website.Models
{
	[Table("ProductQuantities")]
	public class ProductQuantity : BaseModel
	{
		[Key]
		public int PROQ_ID { get; set; }

		[Required(ErrorMessage = "Please enter product id!")]
		[DisplayName("Product ID")]
		public required int PRO_ID { get; set; }

		[Required(ErrorMessage = "Please enter product quantity!")]
		[DisplayName("Product Quantity")]
		public required int PROQ_Quantity { get; set; }

		[ForeignKey("PRO_ID")]
		public virtual Product? Product { get; set; }
	}
}
