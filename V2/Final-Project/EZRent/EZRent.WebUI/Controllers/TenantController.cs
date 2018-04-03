using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZRent.Service.Interface;
using EZRent.WebUI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using EZRent.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace EZRent.WebUI.Controllers
{
    [Authorize(Roles ="Tenant")]
    public class TenantController : BaseController
    {
        private ITenantServices _tenantServices;
        private ILeaseServices _leaseServices;
        private IPropertyServices _propertyServices;
        private IBankServices _bankServices;
        private IPaymentServices _paymentServices;

        public TenantController(ITenantServices tenantServices,
            ILeaseServices leaseServices,
            IPropertyServices propertyServices,
            IBankServices bankServices,
            IPaymentServices paymentServices,
            UserManager<ApplicationUser> userManager) : base(userManager)
        {
            _tenantServices = tenantServices;
            _leaseServices = leaseServices;
            _propertyServices = propertyServices;
            _bankServices = bankServices;
            _paymentServices = paymentServices;
        }

        public async Task<IActionResult> Index()
        {
            var t = await GetApplicationUser();
            var p = _propertyServices.GetPropertyByTenantId(t.Id);
            var l = _leaseServices.GetLeaseByPropertyAndTenantId(p.Id, t.Id);

            var model = new TenantPropertyViewModel()
            {
                Property = p,
                Tenant = t
            };
            
            return View(model);
        }

        public async Task<IActionResult> Bank(string id)
        {
            var t = await GetApplicationUser();

            List<Bank> banks = _bankServices.GetBanksByTenantId(t.Id);
            var viewModel = new TenantBanksViewModel();
            viewModel.Banks = banks;
            viewModel.Tenant = t;
            return View(viewModel);
        }

        public IActionResult CreateBank(Bank newBank)
        {
            _bankServices.CreateBank(newBank);
            return RedirectToAction("Bank", new { id = newBank.UserId });
        }

        public async Task<IActionResult> Payments()
        {
            var t = await GetApplicationUser();
            var p = _propertyServices.GetPropertyByTenantId(t.Id);
            var payments = _paymentServices.GetPaymentsByPropertyID(p.Id);

            return View(payments);
        }
    }
}