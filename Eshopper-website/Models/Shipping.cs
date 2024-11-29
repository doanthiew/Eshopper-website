using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshopper_website.Models
{
	[Table("Shippings")]
	public class Shipping : BaseModel
	{
		[Key]
		public int SHIP_ID { get; set; }

		[Required(ErrorMessage = "Please enter the shipping price!")]
		[DisplayName("Price")]
		public decimal SHIP_Price { get; set; }

		[Required(ErrorMessage = "Please enter ward name!"), MinLength(5), MaxLength(255)]
		[DisplayName("Ward")]
		public required string SHIP_Ward { get; set; }

		[Required(ErrorMessage = "Please enter district name!"), MinLength(5), MaxLength(255)]
		[DisplayName("District")]
		public required string SHIP_District { get; set; }

		[Required(ErrorMessage = "Please enter city name!"), MinLength(5), MaxLength(255)]
		[DisplayName("City")]
		public required string SHIP_City { get; set; }

	}
}
