using Cozy.Domain.Models;
using System;
using System.Collections.Generic;

namespace Cozy.Data.Mock
{
    public static class MockMaintenance
    {
        public static List<Maintenance> list = new List<Maintenance>
        {
            new Maintenance { Id = 1, Title = "Toilet", Description = "Toilet won't flush.", Posted = new DateTime(2016, 9, 10), StatusId = 2, PropertyId = 1 },
            new Maintenance { Id = 1, Title = "Air Conditioner", Description = "The air conditioner stopped working.", Posted = new DateTime(2017, 12, 1), StatusId = 1, PropertyId = 2 },
            new Maintenance { Id = 1, Title = "Shower", Description = "Shower is leaking.", Posted = new DateTime(2018, 1, 14), StatusId = 3, PropertyId = 2 },
        };
    }

}
