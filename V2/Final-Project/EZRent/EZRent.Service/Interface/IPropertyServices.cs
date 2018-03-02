using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface IPropertyServices
    {
        List<Property> GetAllPropertys();
        Property GetSinglePropertyById(int id);
        List<Property> GetPropertiesByLandlordId(int id);

        // Create
        Property CreateProperty(Property newProperty);

        // Update
        Property UpdateProperty(Property updatedProperty);
        // Delete
        bool DeleteProperty(int id);
    }
}
