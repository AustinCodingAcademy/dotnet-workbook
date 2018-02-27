using EZRent.Data.Mock;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRent.Service.Implementation.Mock
{
    public class MockLeaseServices : ILeaseServices
    {
        private List<Lease> _context;

        public MockLeaseServices()
        {
            _context = MockLease.list;
        }

        public Lease CreateLease(Lease newLease)
        {
            int largestId = _context.OrderByDescending(b => b.Id).FirstOrDefault().Id;

            newLease.Id = largestId + 1;
            _context.Add(newLease);

            return newLease;
        }

        public bool DeleteLease(int id)
        {
            Lease toBeDeletedLease = GetSingleLeaseById(id);
            _context.Remove(toBeDeletedLease);

            toBeDeletedLease = GetSingleLeaseById(id);
            if (toBeDeletedLease == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Lease> GetAllLeases()
        {
            return _context;
        }

        public Lease GetSingleLeaseById(int id)
        {
            return _context.SingleOrDefault(b => b.Id == id);
        }

        public Lease UpdateLease(Lease updatedLease)
        {
            Lease oldLease = GetSingleLeaseById(updatedLease.Id);

            _context.Remove(oldLease);
            _context.Add(updatedLease);

            return updatedLease;
        }
    }
}
