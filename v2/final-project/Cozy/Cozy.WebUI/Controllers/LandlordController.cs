using Cozy.Domain.Models;
using Cozy.Service.Interface;
using Cozy.WebUI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Cozy.WebUI.Controllers
{
    public class LandlordController : Controller
    {
        private ILandlordServices _landlordServices;
        private IPropertyServices _propertyServices;
        private ITenantServices _tenantServices;
        private IPaymentServices _paymentServices;
        private ILeaseServices _leaseServices;

        public LandlordController(ILandlordServices landlordServices,
            IPropertyServices propertyServices,
            ITenantServices tenantServices,
            IPaymentServices paymentServices,
            ILeaseServices leaseServices)
        {
            _landlordServices = landlordServices;
            _propertyServices = propertyServices;
            _tenantServices = tenantServices;
            _paymentServices = paymentServices;
            _leaseServices = leaseServices;
        }

        public IActionResult Index()
        {
            var model = new LandlordPropertyViewModel();
            model.Landlord = _landlordServices.GetSingleLandlordById(1);
            model.Properties = _propertyServices.GetAllPropertiesByLandlordId(model.Landlord.Id);

            return View(model);
        }

        public IActionResult Property(int id)
        {
            var model = new PropertyViewModel();
            model.Property = _propertyServices.GetSinglePropertyById(id);
            model.Landlord = _landlordServices.GetSingleLandlordById(model.Property.LandlordId);
            model.Tenant = _tenantServices.GetTenantById(model.Property.CurrentTenantId); // new class property
            model.Payments = _paymentServices.GetPaymentByPropertyId(model.Property.Id);

            return View(model);
        }

        public IActionResult CreateProperty(Property newProperty)
        {
            _propertyServices.CreateProperty(newProperty);

            return RedirectToAction("index");
        }
    }
}
