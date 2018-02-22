using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using School.Domain.Models;
using School.Domain.ViewModels;
using School.WebUI.Services;
using System.Linq;

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

        // List of students
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            StudentSessionViewModel viewModel = new StudentSessionViewModel();
            viewModel.Student = new Student();
            viewModel.AvailableSessions = _sessionService.GetAllSession()
                .Select(s => new SelectListItem() {
                    Value = s.Id.ToString(),
                    Text = s.Name
                }).ToList();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if(ModelState.IsValid)
            {
                student.SessionId = 1;
                //go to db and save the student
            }
            return View(student);
        }

    }
}