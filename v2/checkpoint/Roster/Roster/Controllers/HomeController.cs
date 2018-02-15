using Microsoft.AspNetCore.Mvc;
using Roster.Services;
using Roster.Models;
using System.Collections.Generic;

namespace Roster.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<SessionStudentViewModel> listSessionStudent = new List<SessionStudentViewModel>();

            //Intro, Intermedite, Advance
            var sessions = SessionServices.GetAllSessions();

            foreach(var s in sessions)
            {
                SessionStudentViewModel ssvm = new SessionStudentViewModel();
                ssvm.Session = s;

                List<Student> students = StudentsServices.GetStudentsBySession(s.Id);
                ssvm.Students = students;

                listSessionStudent.Add(ssvm);
            }
            
            return View(listSessionStudent);
        }
    }
}