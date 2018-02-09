using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Roster.Models;

namespace Roster.Services
{
    static class SessionServices
    {
        //Fields
        static private List<Session> _sessions = new List<Session>
        {
            new Session { Id =1, Name = "Intro"},
            new Session { Id =2, Name = "Intermediate"},
            new Session { Id =3, Name = "Advanced"}
        };


        // Properties


        //Method
        static public List<Session> GetSessions()
        {
            return _sessions;
        }

        static public Session GetSingleSession(int id)
        {
            return _sessions.Single(s => s.Id == id);
        }
    }
}
