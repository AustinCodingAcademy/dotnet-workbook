using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace School.Domain.ViewModels
{
    public class StudentSessionViewModel
    {
        public Student Student { get; set; }
        public List<SelectListItem> AvailableSessions { get; set; }
    }
}
