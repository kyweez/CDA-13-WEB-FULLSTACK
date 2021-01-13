using Microsoft.AspNetCore.Mvc;

namespace FreeLancerWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}