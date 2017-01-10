using System.Collections.Generic;

namespace VisualStudioFeatures.Models
{
    public class Repository
    {
        private static Repository sharedRepository = new Repository();
        private Dictionary<string, Product> _products = new Dictionary<string, Product>();
        public static Repository SharedRepository => sharedRepository;
        public IEnumerable<Product> GetProducts => _products.Values;

        public Repository()
        {
            var initialItems = new[] 
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M },
                new Product { Name = "Corner flag", Price = 34.95M }
            };

            foreach( var p in initialItems)
            {
                AddProducts(p);
            }
        }

        public void AddProducts(Product p)
        {
            _products.Add(p.Name, p);
        }
    }
}
