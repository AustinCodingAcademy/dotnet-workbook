using Cozy.Domain.Models;

namespace Cozy.Service.Interface
{
    public interface ILandlordServices
    {
        Landlord GetSingleLandlordById(int id);
    }
}
