using Microsoft.AspNetCore.Mvc;

namespace Cozy.WebUI.Controllers
{
    public class LandlordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
