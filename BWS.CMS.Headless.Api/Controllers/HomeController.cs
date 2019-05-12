using Microsoft.AspNetCore.Mvc;

namespace BWS.CMS.Headless.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
