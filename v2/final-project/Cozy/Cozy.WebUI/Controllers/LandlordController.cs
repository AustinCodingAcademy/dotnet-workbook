using Microsoft.AspNetCore.Mvc;

namespace Cozy.WebUI.Controllers
{
    public class LandlordController : Controller
    {

        // localhost:xxxxx/landlord
        public IActionResult Index()
        {
            // hard coding landlord 1
            // list<properties>
            return View();
        }

        //localhost:xxxx/landlord/property/???
        // IActionResult Property(int id)
        //Display:
            // property
            // tenant
            // payments 



        // form action = landlord/createproperty
        // IActionResult to CreateProperties(????)
        // redirect to Index()
    }
}
