using EZRent.Data.Database;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRent.Service.Implementation.EFCore
{
    public class EFCoreBankServices : IBankServices
    {
        private readonly EZRentDbContext _dbContext;

        public void Bank(EZRentDbContext dbContext)
        {
            dbContext = _dbContext;
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
