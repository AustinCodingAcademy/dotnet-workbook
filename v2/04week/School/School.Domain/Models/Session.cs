using System.Collections.Generic;

namespace School.Domain.Models
{
    public class Session
    {
        // Properties
        // They become columns
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigator
        public List<Student> Students {get;set;}
    }
}
