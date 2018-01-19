using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using VideoStore.Models;
using System;

namespace VideoStore.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "John Smith" },
                new Customer {Id = 2, Name = "Mary Williams" }

            };
        }
    }
}