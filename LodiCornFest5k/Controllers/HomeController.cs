using System.Diagnostics;
using LodiCornFest5k.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LodiCornFest5k.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        [HttpGet("/index")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
