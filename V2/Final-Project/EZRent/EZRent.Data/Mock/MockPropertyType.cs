using System;
using System.Collections.Generic;
using System.Text;
using EZRent.Domain.Models;

namespace EZRent.Data.Mock
{
    public static class MockPropertyType
    {
        public static List<PropertyType> list = new List<PropertyType>()
        {
            new PropertyType{Id=1, Description = "Apartment"},
            new PropertyType{Id=2, Description = "Single Family Home"},
            new PropertyType{Id=3, Description = "Duplex/Triplex/Townhouse"},
            new PropertyType{Id=4, Description = "Mobile"},
            new PropertyType{Id=5, Description = "Dormitory"},
            new PropertyType{Id=6, Description = "Commercial"},
        };
    }
}
