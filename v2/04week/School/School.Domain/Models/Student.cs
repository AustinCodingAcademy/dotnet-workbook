using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int SessionId { get; set; }
        public object Students { get; set; }
    }
}
