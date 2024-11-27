using Microsoft.AspNetCore.Mvc;

namespace Eshopper_website.Controllers
{
	public class CheckoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
