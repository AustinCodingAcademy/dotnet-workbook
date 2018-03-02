using Cozy.Data.Mock;
using Cozy.Domain.Models;
using Cozy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cozy.Service.Implementation.Mock
{
    public class MockBankServices : IBankServices
    {
        private List<Bank> _context;

        public MockBankServices()
        {
            _context = MockBank.list;
        }

        public Bank CreateBank(Bank newBank)
        {

            int largestId = _context.OrderByDescending(b => b.Id).FirstOrDefault().Id;

            newBank.Id = largestId + 1;
            _context.Add(newBank);

            return newBank;
        }

        public bool DeleteBank(int id)
        {
            Bank toBeDeletedBank = GetSingleBankById(id);
            _context.Remove(toBeDeletedBank);

            toBeDeletedBank = GetSingleBankById(id);

            if (toBeDeletedBank == null)
                return true;

            return false;

        }

        public List<Bank> GetBanksByTenantId(int id)
        {
            return _context.Where(b => b.UserId == id).ToList();
        }

        public Bank GetSingleBankById(int id)
        {
            return _context.SingleOrDefault(b => b.Id == id);
        }

        public Bank UpdateBank(Bank updatedBank)
        {
            Bank oldBank = GetSingleBankById(updatedBank.Id);

            _context.Remove(oldBank);
            _context.Add(updatedBank);

            return updatedBank;
        }
    }
}
