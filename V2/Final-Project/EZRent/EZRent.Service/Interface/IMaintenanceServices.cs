using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface IMaintenanceServices
    {
        List<Maintenance> GetAllMaintenances();
        Maintenance GetSingleMaintenanceById(int id);

        // Create
        Maintenance CreateMaintenance(Maintenance newMaintenance);

        // Update
        Maintenance UpdateMaintenance(Maintenance updatedMaintenance);
        // Delete
        bool DeleteMaintenance(int id);
    }
}
