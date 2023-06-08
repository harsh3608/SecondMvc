using Microsoft.AspNetCore.Mvc;

namespace SecondMvc.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
