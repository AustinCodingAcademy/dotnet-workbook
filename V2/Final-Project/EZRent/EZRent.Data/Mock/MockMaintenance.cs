using System;
using System.Collections.Generic;
using System.Text;
using EZRent.Domain.Models;


namespace EZRent.Data.Mock
{
    public static class MockMaintenance
    {
        public static List<Maintenance> list = new List<Maintenance>()
            {
                new Maintenance {Id=1, Description="Broken Window", DateCreated= new DateTime(2018, 02, 19), StatusId=1, Title="Broken Window", PropertyId=1},
                new Maintenance {Id=2, Description="Food's getting warm quickly", DateCreated= new DateTime(2017, 02, 19), StatusId=2, Title="Broken Refrigerator", PropertyId=2},
                new Maintenance {Id=3, Description="Water heater leaking", DateCreated= new DateTime(2018, 02, 11), StatusId=3, Title="Busted Water Heater", PropertyId=3}
            };
        }
    }
}
