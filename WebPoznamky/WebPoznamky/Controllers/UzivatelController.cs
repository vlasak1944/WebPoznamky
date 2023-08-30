using Microsoft.AspNetCore.Mvc;
using WebPoznamky.Data;
using WebPoznamky.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
namespace WebPoznamky.Controllers
{
    public class UzivatelController : Controller
    {
        private readonly WebPoznamkyContext _context;

        public UzivatelController(WebPoznamkyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Prihlasit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrovat()
        {
            return View();
        }

    }
}