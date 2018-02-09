using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.WebUI.Services;

namespace School.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private SessionServices _sessionService;

        public HomeController(SessionServices sessionService)
        {
            _sessionService = sessionService;
        }

        public IActionResult Index()
        {
            var sessions = _sessionService.GetAllSessions();

            return View(sessions);
        }
    }
}