using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.Service.Interface
{
    public interface IMaintenanceServices
    {
        Maintenance GetMaintenanceById(int id);
        List<Maintenance> GetMaintenancesByPropertyId(int propertyId);
        Maintenance CreateMaintenance(Maintenance newMaintenance);
        Maintenance UpdateMaintenance(Maintenance updatedMaintenance);
        bool DeleteMaintenance(int id);
    }
}
