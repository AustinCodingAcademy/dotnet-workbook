using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using EZRent.WebUI.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EZRent.WebUI.Controllers
{
    [Authorize(Roles = "Landlord")]
    public class LandlordController : Controller
    {
        private ILandlordServices _landlordServices;
        private IPaymentServices _paymentServices;
        private ITenantServices _tenantServices;
        private IPropertyServices _propertyServices;
        private ILeaseServices _leaseServices;
        private IHostingEnvironment _environment; // null


        public LandlordController(ILandlordServices landlordServices,
            IPaymentServices paymentServices,
            ITenantServices tenantServices,
            IPropertyServices propertyServices,
            ILeaseServices leaseServices,
            IHostingEnvironment environment)
        {
            _landlordServices = landlordServices;
            _paymentServices = paymentServices;
            _tenantServices = tenantServices;
            _propertyServices = propertyServices;
            _leaseServices = leaseServices;
            _environment = environment;
        }


        public IActionResult Index()
        {
            var n = _landlordServices.GetSingleLandlordById(1);

            List<Property> pList = _propertyServices.GetPropertiesByLandlordId(n.Id);

            var model = new LandlordPropertyLeasePaymentViewModel();
            model.Landlord = n;
            model.PropertyList = pList;
            

            //List<Lease> leaseList = new List<Lease>();
            //foreach (var p in pList)
            //{
            //    leaseList.Add(_leaseServices.GetLeaseByPropertyAndTenantId(p.Id));
            //}

            //model.LeaseList = leaseList;

            return View(model);
        }

        public IActionResult Property(int id)
        {
            var model = new PropertyViewModel();
            model.Property = _propertyServices.GetSinglePropertyById(id);
            model.Landlord = _landlordServices.GetSingleLandlordById(model.Property.LandlordId);
            model.Tenant = _tenantServices.GetSingleTenantById(model.Property.CurrentTenantId);
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

                if(file.Length > 0) //weight of file (kb, mb, etc)
                {
                    // 
                    string storageFolder = Path.Combine(_environment.WebRootPath, "images/properties");

                    using (var fileStream = new FileStream(Path.Combine(storageFolder, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    } 

                    //now image is stored in images/properties folder
                    newProperty.Image = $"images/properties/{file.FileName}";

                    _propertyServices.CreateProperty(newProperty);
                }
                else
                {
                    newProperty.Image = "http://www.placehold.it/300x300";
                }
            }

            return RedirectToAction("index");
            
        }
    }
}