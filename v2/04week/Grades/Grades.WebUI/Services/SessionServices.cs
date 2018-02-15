using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace Grades.WebUI.Services
{
    public class SessionServices
    {
        private GradesDbContext _context;

        public SessionServices(GradesDbContext context)
        {
            _context = context;
        }

        public Grades GetSingleGradeById(int Id)
        {
            return _context.Grades.Single(g => g.Id == id);
        }

        public List<Grades> GetAllGrades()
        {
            return _context.Grades.ToList();
        }
    }
}
