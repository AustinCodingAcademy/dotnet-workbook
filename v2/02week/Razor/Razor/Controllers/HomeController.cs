using Microsoft.AspNetCore.Mvc;
using Razor.Models;
using System.Collections.Generic;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> list = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Category = "Watersports",
                    Price = 275M
                },
                new Product
                {
                    ProductID = 2,
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Category = "Watersports",
                    Price = 275M
                }
            };

            return View(list);
        }

        public IActionResult Detail(int id)
        {
            //get the detail
            return View();
        }
    }
}