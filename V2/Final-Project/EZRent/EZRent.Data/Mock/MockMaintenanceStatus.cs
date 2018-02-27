using System;
using System.Collections.Generic;
using System.Text;
using EZRent.Domain.Models;


namespace EZRent.Data.Mock
{
    public static class MockMaintenanceStatus
    {
        public static List<MaintenanceStatus> list = new List<MaintenanceStatus>()
            {
                new MaintenanceStatus {Id=1, Description="New"},
                new MaintenanceStatus {Id=2, Description="Fixed"},
                new MaintenanceStatus {Id=3, Description="In-Progress"},
                new MaintenanceStatus {Id=4, Description="Not a defect"}
            };
        }
    }
}
