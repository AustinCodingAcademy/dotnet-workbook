using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface ILeaseServices
    {
        List<Lease> GetAllLeases();
        Lease GetSingleLeaseById(int id);

        // Create
        Lease CreateLease(Lease newLease);

        // Update
        Lease UpdateLease(Lease updatedLease);
        // Delete
        bool DeleteLease(int id);
    }
}
