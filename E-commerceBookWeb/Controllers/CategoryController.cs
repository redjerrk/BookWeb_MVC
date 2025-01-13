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
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display Order can't exactly match the Name");
            }

            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category Added Successfully";
                return RedirectToAction("Index");
            }

            return View();

        }
        public IActionResult Edit(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            Category categroyFromDb = _db.Categories.Find(id);
            if (categroyFromDb == null)
            {
                return NotFound();
            }
            return View(categroyFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["update"] = "Category Updated Successfully";
                return RedirectToAction("Index");
            }

            return View();

        }

        public IActionResult Delete(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            Category categroyFromDb = _db.Categories.Find(id);
            if (categroyFromDb == null)
            {
                return NotFound();
            }
            return View(categroyFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _db.Categories.Find( id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["delete"] = "Category Deleted Successfully";
            return RedirectToAction("Index");

            

        }




    }
}
