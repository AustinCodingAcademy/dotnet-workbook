using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cozy.WebUI.ViewModel
{
    public class PropertiesTenantPaymentsViewModel
    {
        public Property Property { get; set; }

        public Tenant Tenant { get; set; }

        public List<Payment> Payments { get; set; }


    }
}
