using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor1.Models;

namespace Razor1.Controllers
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
                    Name = "Canoe",
                    Description = "A boat for two people",
                    Category = "Watersports",
                    Price = 310M
                },
                new Product
                {
                    ProductID = 3,
                    Name = "Backpack",
                    Description = "A pack for your back",
                    Category = "Outdoor",
                    Price = 30M
                },
                new Product
                {
                    ProductID = 4,
                    Name = "Sneakers",
                    Description = "Like socks, but tougher",
                    Category = "Footwear",
                    Price = 90M
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