using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithVisualStudio.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public static SimpleRepository SharedRepository => sharedRepository;

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product {Name = "Kayak", Price = 275m },
                new Product {Name = "Lifejacket", Price = 48.95m },
                new Product {Name = "Soccer ball", Price = 19.50m },
                new Product {Name = "Corner Flag", Price = 34.95m }
            };
            foreach (var p in initialItems)
            {
                AddProduct(p);
            }
            products.Add("Error", null);
        }

        

        public IEnumerable<Product> Products => products.Values;

        public void AddProduct(Product p) => products.Add(p.Name, p);
    }
}
