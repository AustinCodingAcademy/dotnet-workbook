using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CableProvider.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CableProvider.UI.Controllers
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
            var sessions = _sessionService.GetAllLocations();
            return View(sessions);
        }
    }
}