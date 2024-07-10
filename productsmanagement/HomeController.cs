using Microsoft.AspNetCore.Mvc;

namespace productsmanagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}