using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Grades.WebUI.Services;

namespace Grades.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private GradeServices _gradeService;

        public HomeController(GradeServices gradeService)
        {
            _gradeService = gradeService;
        }

        public IActionResult Index()
        {
            var grades = _gradeService.GetAllGrades();

            return View(grades);
        }
    }
}