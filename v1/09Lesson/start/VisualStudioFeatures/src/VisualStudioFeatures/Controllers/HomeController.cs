using Microsoft.AspNetCore.Mvc;
using VisualStudioFeatures.Models;
using System.Linq;

namespace VisualStudioFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.SharedRepository.GetProducts);
        }
    }
}
