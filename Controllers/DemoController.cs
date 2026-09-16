using Microsoft.AspNetCore.Mvc;

namespace API_Test.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index_View2()
        {
            int var = 10;
            return View();
        }
       
    }
}
