using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshopper_website.Models
{
	[Table("Transactions")]
	public class Transaction
	{
		[Key]
		public int TRANS_ID { get; set; }
	}
}
