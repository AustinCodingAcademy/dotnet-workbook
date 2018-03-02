using Cozy.Domain.Models;

namespace Cozy.Service.Interface
{
    public interface IMaintenanceServices
    {
        Maintenance GetMaintenanceById(int id);
        Maintenance GetMaintenanceByPropertyId(int propertyId);
        Maintenance CreateMaintenance(Maintenance newMaintenance);
        Maintenance UpdateMaintenance(Maintenance updatedMaintenance);
        bool DeleteMaintenance(int id);
    }
}
