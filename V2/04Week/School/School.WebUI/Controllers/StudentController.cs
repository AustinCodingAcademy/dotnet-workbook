using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using School.Domain.Models;
using School.Domain.ViewModels;
using School.WebUI.Services;

namespace School.WebUI.Controllers
{
    
    public class StudentController : Controller
    {
        private StudentServices _studentService;
        private SessionServices _sessionService;

        public StudentController(StudentServices studentService,
                                 SessionServices sessionService)
        {
            _studentService = studentService;
            _sessionService = sessionService;
        }

        //List of Students
        public IActionResult Index()
        {
            return View();
        }

        //Create a new student & Hardcode SessionID
        [HttpGet]
        public IActionResult CreateStudent()
        {
            StudentSessionViewModel viewModel = new StudentSessionViewModel();
            viewModel.Student = new Student();
            viewModel.AvailableSessions = _sessionService.GetAllSessions()
                .Select(s => new SelectListItem()
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                }).ToList();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {

            if (ModelState.IsValid)
            {
                student.SessionId = 1;
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var student = _studentService.GetStudentById(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student updatedStudent)
        {
            _studentService.UpdateStudent(updatedStudent);
            return RedirectToAction("CreateStudent");
        }

        public IActionResult Delete(int id)
        {
            _studentService.Delete(id);
            return RedirectToAction("CreateStudent");
        }
    }
}