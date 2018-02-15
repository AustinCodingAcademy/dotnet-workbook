using System;
using System.Collections.Generic;
using System.Text;

namespace Grades.Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int GradeId { get; set; }
    }
}
