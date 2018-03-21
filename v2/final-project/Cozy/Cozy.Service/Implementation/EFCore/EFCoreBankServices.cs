using Cozy.Data.Database;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cozy.Service.Implementation.EFCore
{
    public class EFCoreBankServices : IBankServices
    {
        private readonly CozyDbContext _dbContext;

        public EFCoreBankServices(CozyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Bank CreateBank(Bank newBank)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBank(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bank> GetBanksByTenantId(int id)
        {
            return _dbContext.Banks.Where(b => b.UserId == id).ToList();
        }

        public Bank GetSingleBankById(int id)
        {
            return _dbContext.Banks.SingleOrDefault(b => b.Id == id);
        }

        public Bank UpdateBank(Bank updatedBank)
        {
            throw new NotImplementedException();
        }
    }
}
