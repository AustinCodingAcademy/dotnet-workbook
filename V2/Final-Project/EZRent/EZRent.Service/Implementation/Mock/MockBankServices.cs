using EZRent.Data.Mock;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EZRent.Service.Implementation.Mock
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
            if(toBeDeletedBank == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Bank> GetAllBanks()
        {
            return _context;
        }

        public Bank GetSingleBankById(int id)
        {
            return _context.SingleOrDefault(b => b.Id == id);
        }

        public Bank GetSingleBankByUserId(int id)
        {
            return _context.SingleOrDefault(b => b.UserId == id);
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
