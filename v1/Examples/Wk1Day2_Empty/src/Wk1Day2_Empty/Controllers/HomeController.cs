using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wk1Day2_Empty.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Wk1Day2_Empty.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string[] myArray = new string[] { "ACA", "Dotnet", "Core" };
            ViewData["my_arr"] = myArray;
            // Looking in the Product model and you will find the GetProducts() method
            // the GetProducts() method adds items statically to the Product domain model
            // below i create a anonymous type and call the GetProducts() class method
            var product = Product.GetProducts();
            
            return View(product);
        }
    }
}
