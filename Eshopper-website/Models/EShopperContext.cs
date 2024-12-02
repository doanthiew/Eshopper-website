using Microsoft.EntityFrameworkCore;

namespace Eshopper_website.Models
{
	public class EShopperContext : DbContext
	{
		public EShopperContext(DbContextOptions<EShopperContext> options) : base(options)
		{
		}

		public DbSet<Brand> Brands { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
	}
}
