using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EZRent.WebUI.ViewModel
{
    public class LandlordPropertyLeaseViewModel
    {
        public Landlord Landlord { get; set; }
        public List<Property> PropertyList { get; set; }
        public List<Lease> LeaseList { get; set; }
    }
}
