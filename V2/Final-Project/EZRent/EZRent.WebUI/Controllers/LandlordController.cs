﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using EZRent.WebUI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EZRent.WebUI.Controllers
{
    public class LandlordController : Controller
    {
        private ILandlordServices _landlordServices;
        private IPaymentServices _paymentServices;
        private ITenantServices _tenantServices;
        private IPropertyServices _propertyServices;
        private ILeaseServices _leaseServices;


        public LandlordController(ILandlordServices landlordServices,
            IPaymentServices paymentServices,
            ITenantServices tenantServices,
            IPropertyServices propertyServices,
            ILeaseServices leaseServices)
        {
            _landlordServices = landlordServices;
            _paymentServices = paymentServices;
            _tenantServices = tenantServices;
            _propertyServices = propertyServices;
            _leaseServices = leaseServices;
        }

        public IActionResult Index()
        {
            var n = _landlordServices.GetSingleLandlordById(1);

            List<Property> pList = _propertyServices.GetPropertiesByLandlordId(n.Id);

            var model = new LandlordPropertyLeaseViewModel();
            model.Landlord = n;
            model.PropertyList = pList;

            // var lease = model.PropertyList.
            List<Lease> leaseList = new List<Lease>
            foreach (var p in pList)
            {
                _leaseServices.GetLeaseByProperty(p.Id)
            }


            return View(model);
        }
    }
}