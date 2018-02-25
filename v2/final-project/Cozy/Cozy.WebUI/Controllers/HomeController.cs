using Cozy.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Cozy.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IBankServices _bankServices;

        public HomeController(IBankServices bankServices)
        {
            _bankServices = bankServices;
        }


        public IActionResult Index()
        {
            var model = _bankServices.GetAllBanks();
            return View(model);
        }
    }
}