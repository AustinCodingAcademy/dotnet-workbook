using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.Service.Interface
{
    public interface IPropertyServices
    {
        List<Property> GetAllPropertiesByLandlordId(int userId);
        Property GetSinglePropertyById(int id);
        Property CreateProperty(Property newProperty);
        Property UpdateProperty(Property updatedPorperty);
        bool DeleteProperty(int id);
    }
}
