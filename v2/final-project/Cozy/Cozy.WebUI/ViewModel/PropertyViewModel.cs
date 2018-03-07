using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.WebUI.ViewModel
{
    public class PropertyViewModel
    {
        public Landlord Landlord { get; set; }
        public Tenant Tenant { get; set; }
        public Property Property { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
