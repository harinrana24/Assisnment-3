using Microsoft.AspNetCore.Mvc;

namespace MovieMVC.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
