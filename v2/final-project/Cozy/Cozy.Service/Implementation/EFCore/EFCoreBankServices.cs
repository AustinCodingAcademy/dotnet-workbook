using Cozy.Data.Database;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
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
            _dbContext.Banks.Add(newBank);
            _dbContext.SaveChanges();

            return newBank;
        }

        public bool DeleteBank(int id)
        {
            var bank = _dbContext.Banks.Find(id);

            _dbContext.Banks.Remove(bank);
            _dbContext.SaveChanges();

            if(_dbContext.Banks.Find(id) == null)
            {
                return true;
            }

            return false;
        }

        public List<Bank> GetBanksByTenantId(int id)
        {
            return _dbContext.Banks.Where(b => b.UserId == id).ToList();
        }

        public Bank GetSingleBankById(int id)
        {
            return _dbContext.Banks.Find(id);
        }

        public Bank UpdateBank(Bank updatedBank)
        {
            var bank = _dbContext.Banks.Update(updatedBank);
            _dbContext.SaveChanges();

            return bank.Entity;
        }
    }
}
