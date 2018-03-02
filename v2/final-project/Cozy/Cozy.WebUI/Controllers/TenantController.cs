using Cozy.Service.Interface;
using Cozy.WebUI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Cozy.WebUI.Controllers
{
    public class TenantController : Controller 
    {
        private ITenantServices _tenantServices;
        private ILeaseServices _leaseServices;
        private IPropertyServices _propertyServices;

        public TenantController(ITenantServices tenantServices, 
            ILeaseServices leaseServices, 
            IPropertyServices propertyServices)
        {
            _tenantServices = tenantServices;
            _leaseServices = leaseServices;
            _propertyServices = propertyServices;
        }

        public IActionResult Index()
        {
            // tenant - TenatService
            var t = _tenantServices.GetTenantById(1);

            // lease - active
            var l = _leaseServices.GetLeaseByTenantId(t.Id);

            // property
            var p = _propertyServices.GetSinglePropertyById(l.PropertyId);

            var model = new TenantPropertyViewModel();
            model.Property = p;
            model.Tenant = t;

            return View(model);
        }
    }
}
