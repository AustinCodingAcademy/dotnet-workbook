using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EZRent.WebUI.ViewModel
{
    public class LandlordPropertyViewModel
    {
        public ApplicationUser Landlord { get; set; }
        public List<Property> PropertyList { get; set; }
        public List<Lease> LeaseList { get; set; }
        public List<Payment> PayList { get; set; }
        public Tenant Tenant { get; set; }
        public List<PropertyType> PropertyTypes { get; set; }
    }
}
