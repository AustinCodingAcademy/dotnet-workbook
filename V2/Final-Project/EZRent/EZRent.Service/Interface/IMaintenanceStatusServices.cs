using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface IMaintenanceStatusServices
    {
        List<MaintenanceStatus> GetAllMaintenanceStatuses();
        MaintenanceStatus GetSingleMaintenanceStatusById(int id);
    }
}
