using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class StudentsController : Controller
    {
        ITIContext db = new ITIContext();
        public IActionResult Index()
        {
            List<Student> std = db.Student.ToList();
            return View("index",std);
        }
        public IActionResult Details(int id)
        {
            Student std = db.Student.FirstOrDefault(a => a.Id == id);
            return View("Details", std);
        }
    }
}
