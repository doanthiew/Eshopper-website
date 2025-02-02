﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshopper_website.Models
{
	[Table("Coupons")]
	public class Coupon : BaseModel
	{
		[Key]
		public int COUP_ID { get; set; }

		[Required(ErrorMessage = "Please enter coupon name!"), MinLength(5), MaxLength(255)]
		[DisplayName("Name")]
		public required string COUP_Name { get; set; }

		[Required(ErrorMessage = "Please enter coupon description!"), MinLength(5), MaxLength(255)]
		[DisplayName("Description")]
		public required string COUP_Description { get; set; }

		[Required(ErrorMessage = "Please enter coupon status!")]
		[DisplayName("Status")]
		public required int COUP_Status { get; set; }

		[Required(ErrorMessage = "Please enter coupon quantity!")]
		[DisplayName("Quantity")]
		public required int COUP_Quantity { get; set; }

		[Required(ErrorMessage = "Please enter the date start for coupon!")]
		[DisplayName("Date Start")]
		public required DateTime COUP_DateStart { get; set; } = DateTime.Now;

		[Required(ErrorMessage = "Please enter the date expire for coupon!")]
		[DisplayName("Date Expire")]
		public required DateTime COUP_DateExpire { get; set; } = DateTime.Now;
	}
}
