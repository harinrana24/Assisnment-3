using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MovieMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        
        public IActionResult Info(string name, int numTimes = 1)
        {
          
            return Content(HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}"));
        }

        public IActionResult Welcome()
        {
            return Content("This is the Welcome action method, the other custom Controller method Welcome()");
        }


        public IActionResult Index()
        {
            return Content("This is the default action! The default Controller method. Always named Index()!");
        }

        public IActionResult Verify(string name, int ID = 1)
        {
            return Content(HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}"));
        }
    }
}
