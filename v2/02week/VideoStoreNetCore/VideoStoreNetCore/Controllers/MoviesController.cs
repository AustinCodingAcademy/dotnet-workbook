using Microsoft.AspNetCore.Mvc;
using VideoStoreNetCore.ViewModels;
using VideoStoreNetCore.Models;
using System.Collections.Generic;

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
                Name = "Star Wars - The last Jedi"
            };

            model.Customers = new List<Customer>
            {
                new Customer {Name = "Erik"},
                new Customer {Name = "Andres"},
                new Customer {Name = "John"},
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
