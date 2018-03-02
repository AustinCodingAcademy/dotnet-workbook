using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Domain.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public int PropertyTypeId { get; set; }
        string Image { get; set; }
        public int LandlordId { get; set; }
        // navigation
        public PropertyType Type { get; set; }


    }
}
