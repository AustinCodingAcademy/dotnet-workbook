using Cozy.Domain.Models;
using System;
using System.Collections.Generic;

namespace Cozy.Data.Mock
{
    public static class MockMaintenance
    {
        public static List<Maintenance> list = new List<Maintenance>
        {
            new Maintenance { Id = 1, Title = "Kitchen sink", Description = "The kitchen sink smells ready bad.", Posted = new DateTime(2016, 9, 10), StatusId = 2, PropertyId = 1 },
            new Maintenance { Id = 1, Title = "Carpet is loose", Description = "The corner of the carpet is loose and i trip all the time.", Posted = new DateTime(2017, 12, 1), StatusId = 1, PropertyId = 2 },
            new Maintenance { Id = 1, Title = "Garage door", Description = "The Garage door is not respoding to any clicker or wall button.", Posted = new DateTime(2018, 1, 14), StatusId = 3, PropertyId = 2 },
        };
    }

}
