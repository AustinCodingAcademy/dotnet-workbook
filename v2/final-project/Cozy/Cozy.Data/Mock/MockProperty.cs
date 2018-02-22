﻿using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.Data.Mock
{
    public static class MockProperty
    {
        public static List<Property> list = new List<Property>
        {
            new Property { Id=1, Address="123 Main Street", City="Austin", Image="", PropertyTypeId=1, State="Texas", Zipcode="78753"},
            new Property { Id=2, Address="555 E Street", City="Pflugerville", Image="", PropertyTypeId=2, State="Texas", Zipcode="78753"},
            new Property { Id=3, Address="987 Rubber Duck", City="Austin", Image="", PropertyTypeId=3, State="Texas", Zipcode="78753"},
            new Property { Id=4, Address="666 Evil Street", City="Hell", Image="", PropertyTypeId=4, State="Texas", Zipcode="78753"},
            new Property { Id=5, Address="678 West Lamp Ave", City="Austin", Image="", PropertyTypeId=5, State="Texas", Zipcode="78753"},
            new Property { Id=6, Address="15049 N Duval St", City="Tallahassee", Image="", PropertyTypeId=6, State="Texas", Zipcode="78753"},
        };
    }
}
