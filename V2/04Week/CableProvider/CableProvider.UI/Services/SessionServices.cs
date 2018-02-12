using CableProvider.Data;
using CableProvider.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CableProvider.UI.Services
{
    public class SessionServices
    {
        private CableProviderDbContext _context;

        public SessionServices(CableProviderDbContext context)
        {
            _context = context;
        }

        //Methods

        public Location GetSingleLocationById(int id)
        {
           return _context.Locations.Single(s => s.Id == id);
        }

        public List<Location> GetAllLocations()
        {
            return _context.Locations.ToList();
        }
    }
}
