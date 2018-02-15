using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Domain.Models;
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

        [HttpGet]
        public IActionResult CreateSession()
        {
            var sessions = _sessionService.GetAllSessionsWithStudents();

            return View(sessions);
        }

        [HttpPost]
        public IActionResult CreateSession(Session session)
        {
            _sessionService.CreateSession(session);
            return RedirectToAction("CreateSession");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var session = _sessionService.GetSingleSessionById(id);
            return View(session);
        }

        [HttpPost]
        public IActionResult Update(Session updatedSession)
        {
            _sessionService.UpdateSession(updatedSession);
            return RedirectToAction("CreateSession");
        }

        public IActionResult Delete(int id)
        {
            _sessionService.Delete(id);
            return RedirectToAction("CreateSession");

        }
    }
}