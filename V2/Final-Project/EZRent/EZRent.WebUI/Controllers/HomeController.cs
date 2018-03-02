using EZRent.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EZRent.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IBankServices _bankServices;
        private ILandlordServices _landlordServices;
        private ILeaseServices _leaseServices;
        private ILeaseTypeServices _leaseTypeServices;
        private IMaintenanceServices _maintenanceServices;
        private IMaintenanceStatusServices _maiontenanceStatusServices;
        private IPaymentServices _paymentServices;
        private IPaymentStatusServices _paymentStatusServices;
        private IPropertyServices _propertyServices;
        private IPropertyTypeServices _propertyTypeServices;
        private ITenantServices _tenantServices;

        public HomeController(IBankServices bankServices)
        {
            _bankServices = bankServices;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}