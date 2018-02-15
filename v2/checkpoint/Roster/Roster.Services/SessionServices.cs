using System;
using System.Collections.Generic;
using System.Text;
using Roster.Models;
using System.Linq;

namespace Roster
{
    static class SessionServices
    {
        // Fields
        static private List<Session> _sessions = new List<Session>
        {
            new Session { Id = 1 , Name="Intro"},
            new Session { Id = 2 , Name= "Intermediate"},
            new Session { Id = 3 , Name = "Advance"}
        };

        // Method
        static public List<Session> GetSessions()
        {
            return _sessions;
        }

        static public Session GetSingleSession(int id)
        {
            return _sessions.Single(session => session.Id == id);
        }
    }
}
