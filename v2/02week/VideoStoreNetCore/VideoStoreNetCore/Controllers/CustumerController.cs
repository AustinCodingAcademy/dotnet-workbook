using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoStoreNetCore.Models;

namespace VideoStoreNetCore.Controllers
{
    public class CustumerController : Controller
    {
        public List<Customer> listCustomers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Erik"},
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            //LINQ - query listCustomers and get a custumer by id
            // getting a single custumer


            return View(/* the single custumer*/);
        }
    }
}