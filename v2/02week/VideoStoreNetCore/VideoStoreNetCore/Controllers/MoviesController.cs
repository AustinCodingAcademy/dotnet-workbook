using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoStoreNetCore.Models;
using VideoStoreNetCore.ViewModels;

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
                Name = "Star Wars - The Last Jedi"
            };

            model.Customers = new List<Customer>
            {
                new Customer {Name = "Nathan"},
                new Customer {Name = "Collin"},
                new Customer {Name = "Joey"},
                new Customer {Name = "Jarrett"},
                new Customer {Name = "Zak"},
            };

            return View(model);
        }

        // Edit
        public IActionResult Edit(int id)
        {
            return Content($"You passed the value of {id}");
        }


        [Route("movies/released/{year}/{month}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content($"You passed the value of {year}, and {month}");
        }
    }
}
