using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using EZRent.WebUI.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EZRent.WebUI.Controllers
{
    [Authorize(Roles = "Landlord")]
    public class LandlordController : BaseController
    {
        private readonly IPropertyTypeServices _propertyTypeServices;
        private IPropertyServices _propertyServices;
        private IPaymentServices _paymentServices;
        private ILeaseServices _leaseServices;
        private IHostingEnvironment _environment;

        public LandlordController(IPropertyTypeServices propertyTypeServices,
            IPropertyServices propertyServices,
            IHostingEnvironment environment,
            IPaymentServices paymentServices,
            ILeaseServices leaseServices,
            UserManager<ApplicationUser> userManager) : base(userManager)
        {
            _propertyTypeServices = propertyTypeServices;
            _paymentServices = paymentServices;
            _propertyServices = propertyServices;
            _leaseServices = leaseServices;
            _environment = environment;
        }

        private string GetUserId()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var claims = identity.Claims.ToList();

            return claims[0].Value;
        }

        public async Task<IActionResult> Index()
        {
            var landlord = await GetApplicationUser();
            var model = new LandlordPropertyViewModel();

            model.Landlord = landlord;
            model.PropertyList = _propertyServices.GetPropertiesByLandlordId(model.Landlord.Id);
            model.PropertyTypes = new SelectList(_propertyTypeServices.GetPropertyTypes(), "Id", "Description");

            return View(model);
        }

        public async Task<IActionResult> Property(int id)
        {
            var model = new PropertyViewModel();
            model.Property = _propertyServices.GetSinglePropertyById(id);
            model.Landlord = await GetApplicationUser();

            model.Tenant = model.Property.CurrentTenantId != null ? await _userManager.FindByIdAsync(model.Property.CurrentTenantId) : null;
            model.Payments = _paymentServices.GetPaymentsByPropertyID(model.Property.Id);

            return View(model);
        }

        public async Task<IActionResult> CreateProperty(PropertyFormViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // separate the Property and the file
                Property newProperty = viewModel.Property;
                IFormFile file = viewModel.File;

                if(file != null && file.Length > 0) //weight of file (kb, mb, etc)
                {
                    // 
                    string storageFolder = Path.Combine(_environment.WebRootPath, "images/properties");

                    using (var fileStream = new FileStream(Path.Combine(storageFolder, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    } 

                    //now image is stored in images/properties folder
                    newProperty.Image = $"images/properties/{file.FileName}";

                }
                _propertyServices.CreateProperty(newProperty);
               
            }

            return RedirectToAction("index");
            
        }
    }
}