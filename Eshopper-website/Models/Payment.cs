using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshopper_website.Models
{
	[Table("Payments")]
	public class Payment : BaseModel
	{
		[Key]
		public int PAY_ID { get; set; }

		[Required(ErrorMessage = "Please enter payment method name"), MinLength(5), MaxLength(255)]
		[DisplayName("Name")]
		public required string PAY_Name { get; set; }

		[Required(ErrorMessage = "Please enter payment method description"), MinLength(5), MaxLength(255)]
		[DisplayName("Description")]
		public required string PAY_Description { get; set; }

		[Required(ErrorMessage = "Please enter payment method status")]
		[DisplayName("Status")]
		public int PAY_Status { get; set; }
	}
}
