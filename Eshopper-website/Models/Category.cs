﻿using Eshopper_website.Utils.Enum;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshopper_website.Models
{
	[Table("Categories")]
	public class Category : BaseModel
	{
		[Key]
		public int CAT_ID {  get; set; }

		[Required(ErrorMessage = "Please enter category name!"), MinLength(5), MaxLength(255)]
		[DisplayName("Name")]
		public required string CAT_Name { get; set; }

		[Required(ErrorMessage = "Please enter category description!"), MinLength(5), MaxLength(255)]
		[DisplayName("Description")]
		public required string CAT_Description { get; set; }

		[MaxLength(255)]
		[DisplayName("Slug")]
		public string? CAT_Slug { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please enter category status!")]
		[DisplayName("Status")]
		public required CategoryStatusEnum CAT_Status { get; set; }

		[Required(ErrorMessage = "Please enter category display order!")]
		[DisplayName("Display Order")]
		public required int CAT_DisplayOrder { get; set; }

		public virtual ICollection<Product>? Products { get; set; }
	}
}
