using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.Data.Mock
{
    public class MockPropertyType
    {
        public List<PropertyType> list = new List<PropertyType>
        {
            new PropertyType {Id=1, Description="Apartment"},
            new PropertyType {Id=2, Description="Single Family Home"},
            new PropertyType {Id=3, Description="Duplex/Triplex/Townhouse"},
            new PropertyType {Id=4, Description="Mobile"},
            new PropertyType {Id=5, Description="Dormitory"},
            new PropertyType {Id=6, Description="Commercial"},
        };
    }
}
