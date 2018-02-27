using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface ILeaseTypeServices
    {
        List<LeaseType> GetAllLeaseTypes();
        LeaseType GetSingleLeaseTypeById(int id);

    }
}
