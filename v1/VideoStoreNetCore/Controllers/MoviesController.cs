using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoStoreNetCore.Models;

namespace VideoStoreNetCore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            //Create Instance of Movie Model
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);
        }

    }
}
