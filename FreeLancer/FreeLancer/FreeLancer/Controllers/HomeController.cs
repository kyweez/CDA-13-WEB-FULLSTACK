using Microsoft.AspNetCore.Mvc;

namespace FreeLancer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}