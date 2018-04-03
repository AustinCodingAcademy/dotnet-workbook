using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.WebUI.ViewModel
{
    public class LandlordNavBarViewModel
    {
        public int LandlordId { get; set; }
        public List<Property> Properties { get; set;}
    }
}
