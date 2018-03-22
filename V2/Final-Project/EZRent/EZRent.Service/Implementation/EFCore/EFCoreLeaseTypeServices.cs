using EZRent.Data.Database;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Implementation.EFCore
{
    public class EFCoreLeaseTypeServices : ILeaseTypeServices
    {
        private readonly EZRentDbContext _dbContext;


        public EFCoreLeaseTypeServices(EZRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<LeaseType> GetAllLeaseTypes()
        {
            throw new NotImplementedException();
        }

        public LeaseType GetSingleLeaseTypeById(int id) => _dbContext.LeaseTypes.Find(id);

    }
}
