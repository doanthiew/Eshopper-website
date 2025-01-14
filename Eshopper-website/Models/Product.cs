﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshopper_website.Models
{
	[Table("Products")]
	public class Product : BaseModel
	{
		[Key]
		public int PRO_ID { get; set; }

		[Required(ErrorMessage = "Please enter product category!")]
		[DisplayName("Category ID")]
		public required int CAT_ID { get; set; }

		[Required(ErrorMessage = "Please enter product brand!")]
		[DisplayName("Brand ID")]
		public required int BRA_ID { get; set; }

		[Required(ErrorMessage = "Please enter product name!"), MinLength(20), MaxLength(255)]
		[DisplayName("Name")]
		public required string PRO_Name { get; set; }

		[Required(ErrorMessage = "Please enter product description!"), MinLength(5), MaxLength(255)]
		[DisplayName("Description")]
		public required string PRO_Description { get; set; }

		[MaxLength(255)]
		[DisplayName("Slug")]
		public string? PRO_Slug { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please enter product price!")]
		[DisplayName("Price")]
		public required decimal PRO_Price { get; set; }

		[MaxLength(255)]
		[DisplayName("Image")]
		public string? PRO_Image { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please enter product quantity!")]
		[DisplayName("Quantity")]
		public required int PRO_Quantity { get; set; }

		[Required(ErrorMessage = "Please enter product status!")]
		[DisplayName("Status")]
		public required int PRO_Status { get; set; }

		[Required(ErrorMessage = "Please enter product capital price!")]
		[DisplayName("Capital Price")]
		public required decimal PRO_CapitalPrice { get; set; }

		[ForeignKey("CAT_ID")]
		public virtual Category? Category { get; set; }

		[ForeignKey("BRA_ID")]
		public virtual Brand? Brand { get; set; }

		//public virtual ICollection<Wishlist>? Wishlists { get; set; }
		//public virtual ICollection<Compare>? Compares { get; set; }
		public virtual ICollection<Rating>? Ratings { get; set; }
		public virtual ICollection<ProductQuantity>? ProductQuantities { get; set; }
		public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
	}
}
