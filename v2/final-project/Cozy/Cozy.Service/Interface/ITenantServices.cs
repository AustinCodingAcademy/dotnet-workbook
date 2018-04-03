using Cozy.Domain.Models;

namespace Cozy.Service.Interface
{
    public interface ITenantServices
    {
        Tenant GetTenantById(string id);
        object GetTenantById(int id);
    }
}
