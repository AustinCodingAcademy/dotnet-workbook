using System;
using System.Collections.Generic;
using System.Text;
using EZRent.Domain.Models;

namespace EZRent.Data.Mock
{
    public static class MockProperty
    {
        public static List<Property> list = new List<Property>()
        {
            new Property {Id = 1, Address= "1 Main St", City = "Austin", State = "TX", Zipcode = "78701", PropertyTypeId = 1},
            new Property {Id = 2, Address= "11 West Ave", City = "Tampa", State = "FL", Zipcode = "33601", PropertyTypeId = 2},
            new Property {Id = 3, Address= "100 Madison Ave", City = "New York", State = "NY", Zipcode = "10010", PropertyTypeId = 3},
        };
    }
}
