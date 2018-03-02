using Cozy.Domain.Models;

namespace Cozy.Service.Interface
{
    public interface ITenantServices
    {
        Tenant GetTenantById(int id);
    }
}
