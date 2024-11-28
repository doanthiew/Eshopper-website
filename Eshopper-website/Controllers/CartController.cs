using Microsoft.AspNetCore.Mvc;

namespace Eshopper_website.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
