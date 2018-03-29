using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.Data.Mock
{
    public static class MockPropertyType
    {
        public static List<PropertyType> list = new List<PropertyType>
        {
            new PropertyType {Id=1, Description="Apartment"},
            new PropertyType {Id=2, Description="House"},
            new PropertyType {Id=4, Description="Mobile"},
        };
    }
}
