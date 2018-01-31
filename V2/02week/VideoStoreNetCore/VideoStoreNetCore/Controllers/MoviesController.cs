using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoStoreNetCore.ViewModels;
using VideoStoreNetCore.Models;

namespace VideoStoreNetCore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public IActionResult Random()
        {
            MovieCustomerViewModel model = new MovieCustomerViewModel();

            model.Movie = new Movie
            {
                Id = 126,
                Name = "Star Wars: the Last Jedi"
            };

            model.Customers = new List<Customer>
            {
                new Customer { Name ="Erik" },
                new Customer {Name = "Max" },
                new Customer {Name = "Jon" }
            };

            return View(model);
        }


    //Edit
        public IActionResult Edit(int id)
        {
            return Content($"You passed the value of {id}");
        }

        [Route("movies/released/{year}/{month}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content($"You passed the value of {year} and {month}");
        }
    }
}
