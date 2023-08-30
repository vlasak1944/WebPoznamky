using Microsoft.AspNetCore.Mvc;

namespace WebPoznamky.Controllers
{
    public class PoznamkaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
