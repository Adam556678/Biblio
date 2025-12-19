using Microsoft.AspNetCore.Mvc;

namespace Biblio.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }        
    }
}