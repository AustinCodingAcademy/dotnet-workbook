using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface IMaintenanceStatusServices
    {
        MaintenanceStatus GetMaintenanceStatus(int id);
    }
}
