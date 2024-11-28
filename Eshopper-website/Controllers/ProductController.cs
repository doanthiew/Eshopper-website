using Microsoft.AspNetCore.Mvc;

namespace Eshopper_website.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
        public IActionResult Details()
        {
            return View();
        }
    }
}
