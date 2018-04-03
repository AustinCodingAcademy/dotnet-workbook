using System.Collections.Generic;
using Cozy.Domain.Models;

namespace Cozy.Data.Mock
{
    public static class MockMaintenanceStatus
    {
        public static List<MaintenanceStatus> list = new List<MaintenanceStatus>
        {
            new MaintenanceStatus { Id =1, Description = "New"},
            new MaintenanceStatus { Id =1, Description = "Fixed"},
            new MaintenanceStatus { Id =1, Description = "Replacing"},
        };
    }
}
