using Microsoft.AspNetCore.Mvc;

namespace InstallingBootstrapScratch.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
