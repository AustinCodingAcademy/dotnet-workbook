using System.Collections.Generic;
using VideoStore.Models;

namespace VideoStore.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}