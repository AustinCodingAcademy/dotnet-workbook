using DatabaseExample.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DatabaseExample.Controllers
{
    public class CharacterController : Controller
    {
        private readonly CharacterContext _db;

        public CharacterController(CharacterContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Characters.ToList());
        }

    }
}
