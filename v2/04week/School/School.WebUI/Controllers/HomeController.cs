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
        
        // localhost:xxxx/home/index.123/nathan/massey
        public IActionResult Index()
        {
            var sessions = _sessionService.GetAllSessions();

            return View(sessions);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var sessions = _sessionService.GetAllSessions();
            return View(sessions);
        }

        [HttpPost]
        public IActionResult Create(Session session)
        {
            _sessionService.CreateSession(session);
            return RedirectToAction("Create");
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
            return RedirectToAction("Create");
        }

        public IActionResult Delete(int id)
        {
            _sessionService.Delete(id);
            return RedirectToAction("Create");
        }
    }
}