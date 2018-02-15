using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoStoreNetCore.Models;

namespace VideoStoreNetCore.Controllers
{
    public class CustomerController : Controller
    {
        public List<Customer> listCustomers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Nathan Massey"},
            new Customer { Id = 2, Name = "Collin Massey"},
            new Customer { Id = 3, Name = "Jarrett Austin"},
            new Customer { Id = 4, Name = "Joey Tongay"},
            new Customer { Id = 5, Name = "Zak Klepak"},
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int Id)
        {
            // LINQ - Query listCustomers and get a customer by id


            // Getting a single customer
            var customer = listCustomers.Single(/*Lambda expresion */);

            return View(customer);
        }
    }
}