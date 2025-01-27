using BookWebRazor.Data;
using BookWebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookWebRazor.Pages.Categories
{
    public class IndexModel(ApplicationDbContext db) : PageModel
    {
        private readonly ApplicationDbContext _db = db;
        public List<Category>? CategoryList { get; set; }

        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
