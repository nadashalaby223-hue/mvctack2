using Microsoft.AspNetCore.Mvc;
using mvctack2.BL;

namespace mvctack2.Controllers
{
    public class InstructorController : Controller
    {
        InstructorBL bl = new InstructorBL();

        // GET: Instructor/Index
        public IActionResult Index()
        {
            var instructors = bl.GetAllInstructors();
            return View(instructors);
        }

        // GET: Instructor/Details/1
        public IActionResult Details(int id)
        {
            var instructor = bl.GetInstructorById(id);
            if (instructor == null)
            {
                return NotFound();
            }
            return View(instructor);
        }
    }
}