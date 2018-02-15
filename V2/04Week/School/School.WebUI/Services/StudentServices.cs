using School.Data;
using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace School.WebUI.Services
{
    public class StudentServices
    {
        private SchoolDbContext _context;

        public StudentServices(SchoolDbContext context)
        {
            _context = context;
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.SingleOrDefault(st => st.Id == id);
        }

        public List<Student> GetAllStudents() => _context.Students.ToList();

        public List<Student> GetAllStudentsBySession(int sessionId)
        {
            return _context.Students.Where(s => s.SessionId == sessionId).ToList();
        }

        public Student CreateStudent(Student newStudent)
        {
            _context.Students.Add(newStudent);
            _context.SaveChanges();

            return newStudent;
        }

        public Student UpdateStudent(Student updatedStudent)
        {
            var dbUpdatedStudent = _context.Students.Update(updatedStudent);
            _context.SaveChanges();

            return dbUpdatedStudent.Entity;
        }

        public bool Delete(int id)
        {
            var studentToBeDeleted = _context.Students.Find(id);

            _context.Students.Remove(studentToBeDeleted);
            _context.SaveChanges();

            var studentDeleted = GetStudentById(id);

            if(studentDeleted == null)
            {
                return true;
            }
            return false;
        }
    }
}
