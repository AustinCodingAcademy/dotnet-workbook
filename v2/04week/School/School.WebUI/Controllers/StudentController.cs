using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Domain.Models;
using School.Domain.ViewModels;
using School.WebUI.Controllers;
using School.WebUI.Services;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace School.WebUI.Controllers
{
    public class StudentController : Controller
    {
        private StudentServices _studentService;
        private Student updatedStudent;
        private SessionServices _sessionService;

        public StudentController(StudentServices studentService, SessionServices sessionService)
        {
            _studentService = studentService;
            _sessionService = sessionService;
        }

        // List of students
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();

            return View();
        }

        // Create a new student - hard code the session id
        [HttpGet]
        public IActionResult Create()
        {
            StudentSessionViewModel viewModel = new StudentSessionViewModel();
            viewModel.Student = new Student();
            viewModel.AvailableSessions = _sessionService.GetAllSessions()
            .Select(s => new SelectListItem() {
                         Value = s.Id.ToString(),
                         Text = s.Name
        }).ToList();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _studentService.CreateStudent(student);
            return RedirectToAction("Create");
        }

        // Update
        [HttpGet]
        public IActionResult Update(int id)
        {
            var student = _studentService.GetSingleStudentById(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student updatedSession)
        {
            _studentService.UpdateStudent(updatedStudent);
            return RedirectToAction("Create");
        }

        // Delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _studentService.Delete(id);
            return RedirectToAction("Create");
        }
    }
}