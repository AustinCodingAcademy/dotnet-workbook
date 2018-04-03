using Cozy.Domain.Models;

namespace Cozy.Service.Interface
{
    public interface IMaintenanceStatusServices
    {
        MaintenanceStatus GetMaintenanceStatus(int id);
    }
}
