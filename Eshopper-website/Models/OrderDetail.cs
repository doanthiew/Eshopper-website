using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshopper_website.Models
{
	[Table("OrderDetails")]
	public class OrderDetail : BaseModel
	{
		[Key]
		public int ORDE_ID { get; set; }

		[Required(ErrorMessage = "Please enter username!"), MinLength(5), MaxLength(50)]
		[DisplayName("UserName")]
		public required string USER_UserName { get; set; }

		[Required(ErrorMessage = "Please enter order code!"), MinLength(5), MaxLength(50)]
		[DisplayName("Order Code")]
		public required string ORD_OrderCode { get; set; }

		[Required(ErrorMessage = "Please enter product id!")]
		[DisplayName("Product ID")]
		public required int PRO_ID { get; set; }

		[Required(ErrorMessage = "Please enter order details price!")]
		[DisplayName("Price")]
		public required decimal ORDE_Price { get; set; }

		[Required(ErrorMessage = "Please enter order details quantity!")]
		[DisplayName("Quantity")]
		public required int ORDE_Quantity { get; set; }

		[ForeignKey("PRO_ID")]
		public virtual Product? Product { get; set; }
	}
}
