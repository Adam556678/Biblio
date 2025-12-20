using System.Data.Common;
using Biblio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblio.Controllers
{
    public class CategoryController : Controller
    {

        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
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