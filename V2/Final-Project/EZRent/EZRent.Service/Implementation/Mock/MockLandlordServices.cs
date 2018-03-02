using EZRent.Data.Mock;
using EZRent.Domain.Models;
using EZRent.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRent.Service.Implementation.Mock
{
    public class MockLandlordServices : ILandlordServices
    {
        private List<Landlord> _context;

        public MockLandlordServices()
        {
            _context = MockLandlord.list;
        }

        public Landlord CreateLandlord(Landlord newLandlord)
        {
            int largestId = _context.OrderByDescending(b => b.Id).FirstOrDefault().Id;

            newLandlord.Id = largestId + 1;
            _context.Add(newLandlord);

            return newLandlord;
        }

        public bool DeleteLandlord(int id)
        {
            Landlord toBeDeletedLandlord = GetSingleLandlordById(id);
            _context.Remove(toBeDeletedLandlord);

            toBeDeletedLandlord = GetSingleLandlordById(id);
            if (toBeDeletedLandlord == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Landlord> GetAllLandlords()
        {
            return _context;
        }

        public Landlord GetSingleLandlordById(int id)
        {
            return _context.SingleOrDefault(b => b.Id == id);
        }


        public Landlord UpdateLandlord(Landlord updatedLandlord)
        {
            Landlord oldLandlord = GetSingleLandlordById(updatedLandlord.Id);

            _context.Remove(oldLandlord);
            _context.Add(updatedLandlord);

            return updatedLandlord;
        }
    }
}
