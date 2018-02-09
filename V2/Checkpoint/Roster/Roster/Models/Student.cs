using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roster.Models
{
    public class Student
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int SessionId { get; set; }
    }
}
