using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Domain.Models;
using School.WebUI.Services;

namespace School.WebUI.Controllers
{
    
    public class StudentController : Controller
    {
        private StudentServices _studentService;

        public StudentController(StudentServices studentService)
        {
            _studentService = studentService;
        }

        //List of Students
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
        }

        //Create a new student & Hardcode SessionID
        [HttpGet]
        public IActionResult CreateStudent()
        {
            var students = _studentService.GetAllStudents();

            return View(students);
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            _studentService.CreateStudent(student);
            return RedirectToAction("CreateStudent");
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