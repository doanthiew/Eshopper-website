﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshopper_website.Models
{
	[Table("Banners")]
	public class Banner : BaseModel
	{
		[Key]
		public int BAN_ID { get; set; }

		[Required(ErrorMessage = "Please enter banner title"), MinLength(5), MaxLength(255)]
		[DisplayName("Title")]
		public required string BAN_Title { get; set; }

		[Required(ErrorMessage = "Please enter banner image"), MinLength(5), MaxLength(255)]
		[DisplayName("Image")]
		public required string BAN_Image { get; set; }

		[MaxLength(255)]
		[DisplayName("URL")]
		public string? BAN_Url { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please enter banner display order")]
		[DisplayName("Display Order")]
		public required int BAN_DisplayOrder { get; set; }
	}
}
