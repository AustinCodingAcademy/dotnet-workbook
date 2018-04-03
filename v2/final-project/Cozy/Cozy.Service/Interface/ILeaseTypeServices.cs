using Cozy.Domain.Models;

namespace Cozy.Service.Interface
{
    public interface ILeaseTypeServices
    {
        LeaseType GetLeaseType(int id);
    }
}
