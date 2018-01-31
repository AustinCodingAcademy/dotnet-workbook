using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoStoreNetCore.Models;

namespace VideoStoreNetCore.ViewModels
{
    public class MovieCustomerViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
