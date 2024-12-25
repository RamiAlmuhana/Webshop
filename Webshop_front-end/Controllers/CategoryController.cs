using Microsoft.AspNetCore.Mvc;

namespace Webshop_front_end.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
