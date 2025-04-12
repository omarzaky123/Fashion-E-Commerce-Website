using Microsoft.AspNetCore.Mvc;

namespace E_commerce_ITI___UI.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
