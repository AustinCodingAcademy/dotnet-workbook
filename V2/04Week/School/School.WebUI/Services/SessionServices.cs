using School.Data;
using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.WebUI.Services
{
    public class SessionServices
    {
        private SchoolDbContext _context;

        public SessionServices(SchoolDbContext context)
        {
            _context = context;
        }

        // Methods
        public Session GetSingleSessionById(int id)
        {
            return _context.Sessions.Single(s => s.Id == id);
        }

        public List<Session> GetAllSessions()
        {
            return _context.Sessions.ToList();
        }
    }
}
