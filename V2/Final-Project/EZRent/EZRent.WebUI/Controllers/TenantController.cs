using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZRent.Service.Interface;
using EZRent.WebUI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using EZRent.Domain.Models;

namespace EZRent.WebUI.Controllers
{
    public class TenantController : Controller
    {
        private ITenantServices _tenantServices;
        private ILeaseServices _leaseServices;
        private IPropertyServices _propertyServices;
        private IBankServices _bankServices;

        public TenantController(ITenantServices tenantServices,
            ILeaseServices leaseServices,
            IPropertyServices propertyServices,
            IBankServices bankServices)
        {
            _tenantServices = tenantServices;
            _leaseServices = leaseServices;
            _propertyServices = propertyServices;
            _bankServices = bankServices;
        }

        public IActionResult Index()
        {
            // figure out who the tenant is
            var t = _tenantServices.GetSingleTenantById(1);


            // lease - active
            var l = _leaseServices.GetLeaseByTenantId(t.Id);

            // tenants' property
            var p = _propertyServices.GetSinglePropertyById(l.PropertyId);

            var model = new TenantPropertyViewModel();
            model.Property = p;
            model.Tenant = t;
            
            return View(model);
        }

        public IActionResult Bank(int id)
        {
            var tenant = _tenantServices.GetSingleTenantById(id);
            List<Bank> banks = _bankServices.GetBanksByTenantId(id);

            var viewModel = new TenantBanksViewModel();
            viewModel.Banks = banks;
            viewModel.Tenant = tenant;
            return View(viewModel);
        }

        public IActionResult CreateBank(Bank newBank)
        {
            _bankServices.CreateBank(newBank);
            return RedirectToAction("Bank", new { id = newBank.UserId });
        }
    }
}