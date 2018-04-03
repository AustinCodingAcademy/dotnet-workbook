using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.Data.Mock
{
    public static class MockProperty
    {
        public static List<Property> list = new List<Property>
        {
            new Property { Id=1, Address="1st Street", City="Austin", Image="http://www.placehold.it/300x300", PropertyTypeId=1, State="Texas", Zipcode="78757"},
            new Property { Id=2, Address="2nd Street", City="Austin", Image="http://www.placehold.it/300x300", PropertyTypeId=2, State="Texas", Zipcode="78757"},
            new Property { Id=3, Address="3rd Street", City="Austin", Image="http://www.placehold.it/300x300", PropertyTypeId=3, State="Texas", Zipcode="78757"},
        };
    }
}
