using Microsoft.AspNetCore.Mvc;
using VisualStudioFeatures.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace VisualStudioFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(Repository.SharedRepository.GetProducts);
        }
    }
}
