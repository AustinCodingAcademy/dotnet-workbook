using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Roster.Services;
using Roster.Models;

namespace Roster.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<SessionStudentViewModel> listSessionStudent = new List<SessionStudentViewModel>();

            var sessions = SessionServices.GetAllSessions();

            foreach(var s in sessions)
            {
                SessionStudentViewModel ssvm = new SessionStudentViewModel();
                ssvm.Session = s;

                List<Student> students = StudentServices.GetStudentsBySession(s.Id);

                ssvm.Students = students;

                listSessionStudent.Add(ssvm);
            }

            return View(listSessionStudent);
        }
    }
}