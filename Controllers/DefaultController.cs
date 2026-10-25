using Microsoft.AspNetCore.Mvc;

namespace MYacademy_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
