using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roster.Models
{
    public class SessionStudentViewModel 
    {
        public Session Session { get; set; }
        public List<Student> Students { get; set; }
    }
}
