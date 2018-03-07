using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EZRent.WebUI.ViewModel
{
    public class PropertyViewModel
    {
        public Landlord Landlord { get; set; }
        public Tenant Tenant { get; set; }
        public Property Property { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
