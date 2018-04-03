using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZRent.Domain.Models;

namespace EZRent.WebUI.ViewModel
{
    public class TenantPropertyViewModel
    {
        public ApplicationUser Tenant { get; set; }
        public Property Property { get; set; }
    }
}
