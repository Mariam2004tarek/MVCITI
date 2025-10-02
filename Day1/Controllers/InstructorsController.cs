using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class InstructorsController : Controller
    {
        ITIContext db = new ITIContext();
        public IActionResult Index()
        {
            List<Instructor> ins = db.Instructor.ToList();
            return View("index",ins);
        }
        public IActionResult Details(int id)
        {
            Instructor ins = db.Instructor.FirstOrDefault(a => a.Id == id);
            return View("Details", ins);
        }
    }
}
