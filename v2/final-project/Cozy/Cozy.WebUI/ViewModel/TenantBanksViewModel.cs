using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.WebUI.ViewModel
{
    public class TenantBanksViewModel
    {
        //Tenant
        public Tenant Tenant { get; set; }

        //List<Bank>
        public List<Bank> Banks { get; set; }
    }
}
