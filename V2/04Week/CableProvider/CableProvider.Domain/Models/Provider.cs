using System;
using System.Collections.Generic;
using System.Text;

namespace CableProvider.Domain.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InternetSpeed { get; set; }
        public int Price { get; set; }
    }
}
