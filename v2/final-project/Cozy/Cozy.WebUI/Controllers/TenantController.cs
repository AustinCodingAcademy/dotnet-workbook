using Cozy.Domain.Models;
using Cozy.Service.Interface;
using Cozy.WebUI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Cozy.WebUI.Controllers
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
            // tenant - TenantService
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

        public IActionResult Bank(int id)
        {
            var tenant = _tenantServices.GetTenantById(id);
            List<Bank> banks = _bankServices.GetBanksByTenantId(id);

            var viewModel = new TenantBanksViewModel();
            viewModel.Banks = banks;
            viewModel.Tenant = tenant;

            return View(viewModel);
        }

        public IActionResult CreateBank(Bank newBank)
        {
            // save it
            _bankServices.CreateBank(newBank);

            // redirect to a page
            return RedirectToAction("Bank", new { id = newBank.UserId });
        }
    }
}
