using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EZRent.WebUI.ViewModel
{
    public class PropertyViewModel
    {
        public ApplicationUser Landlord { get; set; }
        public ApplicationUser Tenant { get; set; }
        public Property Property { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
