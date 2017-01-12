using Microsoft.AspNetCore.Mvc;
using VisualStudioFeatures.Models;

namespace VisualStudioFeatures.Controllers
{
    public class HomeController : Controller
    {
        Repository _repository = Repository.SharedRepository;

        public IActionResult Index()
        {
            return View(Repository.SharedRepository.GetProducts);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            _repository.AddProducts(p);
            return RedirectToAction("Index");
        }
    }
}
