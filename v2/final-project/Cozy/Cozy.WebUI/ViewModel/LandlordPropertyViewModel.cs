using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.WebUI.ViewModel
{
    public class LandlordPropertyViewModel
    {
        public Landlord Landlord { get; set; }
        public List<Property> Properties { get; set; }
    }
}
