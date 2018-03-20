using Cozy.Domain.Models;
using Cozy.Service.Interface;
using Cozy.WebUI.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace Cozy.WebUI.Controllers
{
    [Authorize]
    public class LandlordController : Controller
    {
        private ILandlordServices _landlordServices;
        private IPropertyServices _propertyServices;
        private ITenantServices _tenantServices;
        private IPaymentServices _paymentServices;
        private ILeaseServices _leaseServices;
        private IHostingEnvironment _environment;

        public LandlordController(ILandlordServices landlordServices,
            IPropertyServices propertyServices,
            ITenantServices tenantServices,
            IPaymentServices paymentServices,
            ILeaseServices leaseServices,
            IHostingEnvironment environment)
        {
            _landlordServices = landlordServices;
            _propertyServices = propertyServices;
            _tenantServices = tenantServices;
            _paymentServices = paymentServices;
            _leaseServices = leaseServices;
            _environment = environment;
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
            model.Payments = _paymentServices.GetPaymentsByPropertyId(model.Property.Id);

            return View(model);
        }

        public async Task<IActionResult> CreateProperty(PropertyFormViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                // separate the Property and File
                Property newProperty = viewModel.Property;
                IFormFile file = viewModel.File;

                if(file.Length > 0) //weight Kb - there is an actual file being uploaded
                {
                    // C:\Users\erikp\Documents\aca\dotnet-workbook\v2\final-project\Cozy\Cozy.WebUI\wwwroot\images\properties\
                    string storageFolder = Path.Combine(_environment.WebRootPath, "images/properties");

                    // C:\Users\erikp\Documents\aca\dotnet-workbook\v2\final-project\Cozy\Cozy.WebUI\wwwroot\images\properties\<fileName>.jpg
                    using (var fileStream = new FileStream(Path.Combine(storageFolder, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    } // remove the item from memory in a efficient way

                    // we have a image stored in the images/property folder

                    newProperty.Image = $"images/properties/{file.FileName}";

                    _propertyServices.CreateProperty(newProperty);
                }

            }

            return RedirectToAction("index");
        }
    }
}
