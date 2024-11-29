using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshopper_website.Models
{
	[Table("Statisticals")]
	public class Statistical : BaseModel
	{
		[Key]
		public int STA_ID { get; set; }

		[Required(ErrorMessage = "Please enter the statistical quantity")]
		[DisplayName("Quantity")]
		public required int STA_Quantity  { get; set; }

		[Required(ErrorMessage = "Please enter the statistical status")]
		[DisplayName("Status")]
		public required int STA_Status { get; set; }

		[Required(ErrorMessage = "Please enter the statistical revenue")]
		[DisplayName("Revenue")]
		public required decimal STA_Revenue { get; set; }

		[Required(ErrorMessage = "Please enter the statistical profit")]
		[DisplayName("Profit")]
		public required double STA_Profit { get; set; }
	}
}
