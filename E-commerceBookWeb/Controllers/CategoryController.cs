using E_commerceBookWeb.Data;
using E_commerceBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_commerceBookWeb.Controllers
{
    public class CategoryController(ApplicationDbContext db) : Controller
    {

        private readonly ApplicationDbContext _db = db;

        public IActionResult Index()
        {

            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
