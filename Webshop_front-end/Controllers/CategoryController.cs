using Microsoft.AspNetCore.Mvc;
using Webshop_front_end.Data;
using Webshop_front_end.Models;

namespace Webshop_front_end.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
