using EZRent.Domain.Models;
using System.Collections.Generic;

namespace EZRent.Service.Interface
{
    public interface IMaintenanceServices
    {
        Maintenance GetSingleMaintenanceById(int id);
        List<Maintenance> GetMaitnenanceByPropertyId(int propertyId);
        // Create
        Maintenance CreateMaintenance(Maintenance newMaintenance);

        // Update
        Maintenance UpdateMaintenance(Maintenance updatedMaintenance);
        // Delete
        bool DeleteMaintenance(int id);
    }
}
