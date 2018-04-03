using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

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
                Price = 275
                },

                new Product
                {
                ProductID = 2,
                Name = "Oar",
                Description = "An oar for a kayak",
                Category = "Watersports",
                Price = 60
                },

                new Product
                {
                ProductID = 3,
                Name = "TV",
                Description = "A 60 inch HD flat screen TV",
                Category = "Electronics",
                Price = 600
                },

                new Product
                {
                ProductID = 4,
                Name = "PC",
                Description = "A home computer",
                Category = "Electronics",
                Price = 1000
                }
            };

            return View(list);
        }

        public IActionResult Detail(int id)
        {
            // Get the detail
            return View();
        }
    }
}