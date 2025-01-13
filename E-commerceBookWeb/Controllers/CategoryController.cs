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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


    }
}
