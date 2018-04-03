using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface IPropertyServices
    {
        Property GetSinglePropertyById(int id);
        List<Property> GetPropertiesByLandlordId(string userId);
        Property GetPropertyByTenantId(string id);

        // Create
        Property CreateProperty(Property newProperty);

        // Update
        Property UpdateProperty(Property updatedProperty);
        // Delete
        bool DeleteProperty(int id);
    }
}
