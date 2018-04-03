using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EZRent.WebUI.ViewModel
{
    public class TenantBanksViewModel
    {
        public ApplicationUser Tenant { get; set; }
        public List<Bank> Banks { get; set; }

    }
}
