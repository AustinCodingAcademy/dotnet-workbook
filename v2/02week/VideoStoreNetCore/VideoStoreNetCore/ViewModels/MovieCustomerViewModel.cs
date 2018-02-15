using System.Collections.Generic;
using VideoStoreNetCore.Models;

namespace VideoStoreNetCore.ViewModels
{
    public class MovieCustomerViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
