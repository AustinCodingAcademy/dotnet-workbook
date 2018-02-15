using Roster.Models;
using System.Collections.Generic;
using System.Linq;

namespace Roster.Services
{
    static class StudentsServices
    {
        //Field
        static private List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "John", LastName = "Cena", SessionId = 1},
            new Student { Id = 2, Name = "Mark", LastName = " Stuard", SessionId = 1},
            new Student { Id = 3, Name = "Erik", LastName = "Zambrano", SessionId = 1},

            new Student {Id = 4, Name = "The", LastName = "North", SessionId = 2},
            new Student {Id = 5, Name = "Face", LastName = "Cell", SessionId = 2},
            new Student {Id = 6, Name = "Mouse", LastName = "Controller", SessionId = 2},

            new Student {Id = 7, Name = "Table", LastName = "Cup", SessionId = 3},
            new Student {Id = 8, Name = "Chair", LastName = "Projector", SessionId = 3},
            new Student {Id = 9, Name = "Carpet", LastName = "Walls", SessionId = 3},
        }; 

        //Methods

        static public Student GetSingleStudent(int id)
        {
            return _students.Single(student => student.Id == id);
        }

        static public List<Student> GetAllStudents()
        {
            return _students;
        }

        static public List<Student> GetStudentsBySession(int sessionId)
        {
            return _students
                .Where(student => student.SessionId == sessionId)
                .ToList();
        }
    }
}
