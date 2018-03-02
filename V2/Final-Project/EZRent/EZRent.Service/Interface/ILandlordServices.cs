using EZRent.Domain.Models;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface ILandlordServices
    {
        List<Landlord> GetAllLandlords();
        Landlord GetSingleLandlordById(int id);
        
        

        // Create
        Landlord CreateLandlord(Landlord newLandlord);

        // Update
        Landlord UpdateLandlord(Landlord updatedLandlord);
        // Delete
        bool DeleteLandlord(int id);
    }
}
