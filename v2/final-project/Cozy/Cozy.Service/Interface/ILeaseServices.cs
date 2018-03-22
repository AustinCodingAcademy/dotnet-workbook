using Cozy.Domain.Models;

namespace Cozy.Service.Interface
{
    public interface ILeaseServices
    {
        Lease GetLeaseByPropertyIdAndTenantId(int propertyId, int tenantId);
        Lease CreateLease(Lease newLease);
        Lease UpdateLease(Lease updatedLease);
        bool DeleteLease(int propertyId, int tenantId);
    }
}
