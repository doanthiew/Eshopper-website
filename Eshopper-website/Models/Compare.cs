using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Eshopper_website.Models
{
	[Table("Compares")]
	public class Compare : BaseModel
	{
		[Key]
		public int COM_ID { get; set; }

		[Required(ErrorMessage = " Please enter product id!")]
		[DisplayName("Product ID")]
		public required int PRO_ID { get; set; }

		[Required(ErrorMessage = " Please enter user id!")]
		[DisplayName("User ID")]
		public required int USER_ID { get; set; }

		[ForeignKey("PRO_ID")]
		public virtual Product? Product { get; set; }

		//[ForeignKey("USER_ID")]
		//public virtual User? User { get; set; }
	}
}
