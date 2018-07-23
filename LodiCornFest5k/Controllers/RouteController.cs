using Microsoft.AspNetCore.Mvc;

namespace LodiCornFest5k.Controllers
{
    public class RouteController : Controller
    {
        [HttpGet("/route/index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}