using Cozy.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Cozy.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IPropertyServices _propertyServices;

        public HomeController(IPropertyServices propertyServices)
        {
            _propertyServices = propertyServices;
        }


        public IActionResult Index()
        {
            var model = _propertyServices.GetSinglePropertyById(1);
            return View(model);
        }
    }
}