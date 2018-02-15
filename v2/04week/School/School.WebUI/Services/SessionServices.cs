using School.Data;
using School.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            return _context.Sessions.SingleOrDefault(s => s.Id == id);
        }

        public List<Session> GetAllSession()
        {
            return _context.Sessions
                .ToList();
        }

        public List<Session> GetAllSessionWithStudents()
        {
            return _context.Sessions
               .Include(s => s.Students)
               .ToList();
        }

        public Session CreateSession(Session newSession)
        {
            _context.Sessions.Add(newSession);
            _context.SaveChanges();

            return newSession;
        }

        public Session UpdateSession(Session updatedSession)
        {
            var dbUpdatedSession = _context.Sessions.Update(updatedSession);
            _context.SaveChanges();

            return dbUpdatedSession.Entity;
        }

        public bool Delete(int id)
        {
            var sessionToBeDeleted = _context.Sessions.Find(id);

            _context.Sessions.Remove(sessionToBeDeleted);
            _context.SaveChanges();

            var sessionDeleted = GetSingleSessionById(id);

            if(sessionDeleted == null)
            {
                return true;
            }

            return false;
        }
    }
}
