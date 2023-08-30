using Microsoft.AspNetCore.Mvc;
using WebPoznamky.Data;
using WebPoznamky.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace WebPoznamky.Controllers
{
    public class UzivatelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}