using Cozy.Domain.Models;
using Microsoft.AspNetCore.Http;

namespace Cozy.WebUI.ViewModel
{
    public class PropertyFormViewModel
    {
        public Property Property { get; set; }
        public IFormFile File { get; set; }
    }
}
