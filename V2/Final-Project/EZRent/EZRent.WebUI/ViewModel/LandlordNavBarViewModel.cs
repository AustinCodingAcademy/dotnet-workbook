using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EZRent.WebUI.ViewModel
{
    public class LandlordNavBarViewModel
    {
        public int LandlordId { get; set; }
        public List<Property> Properties { get; set; }
    }
}
