using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roster.Models;

namespace Roster.Services
{
    static class StudentServices
    {
        //Field
        static private List<Student> _students = new List<Student>
        {
            new Student {Id = 1, Name="Alex", LastName= "Aardvark", SessionId=1},
            new Student {Id = 2, Name="Bill", LastName= "Bull", SessionId=1},
            new Student {Id = 3, Name="Charlie", LastName= "Canaary", SessionId=1},

            new Student {Id = 4, Name="Douglas", LastName= "Dingo", SessionId=2},
            new Student {Id = 5, Name="Emma", LastName= "Elephant", SessionId=2},
            new Student {Id = 6, Name="Frankie", LastName= "Flamingo", SessionId=2},

            new Student {Id = 7, Name="Gus", LastName= "Goat", SessionId=3},
            new Student {Id = 8, Name="Helga", LastName= "Hawk", SessionId=3},
            new Student {Id = 9, Name="Igor", LastName= "Iguana", SessionId=03}
        };



        //Methods
        static public List<Student> GetAllStudents()
        {
            return _students;
        }

        static public Student GetSingleStudent(int id)
        {
            return _students.Single(s => s.Id == id);
        }

        static public List<Student> GetStudentsBySession(int sessionId)
        {
            return _students.Where(student => student.SessionId == sessionId)
                .ToList();
        }
    }
}
