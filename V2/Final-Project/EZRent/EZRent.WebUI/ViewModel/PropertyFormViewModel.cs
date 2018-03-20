using EZRent.Domain.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EZRent.WebUI.ViewModel
{
    public class PropertyFormViewModel
    {
        public Property Property { get; set; }
        public IFormFile File { get; set; }
    }
}
