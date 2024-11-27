using Microsoft.AspNetCore.Mvc;

namespace Eshopper_website.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
