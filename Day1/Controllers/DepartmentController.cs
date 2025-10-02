using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class DepartmentController : Controller
    {
        ITIContext db = new ITIContext();
        public IActionResult Index()
        {
            List<Department> dept = db.Department.ToList();
            return View("index",dept);
        }
        public IActionResult Details(int id)
        {
            Department dept = db.Department.FirstOrDefault(a => a.Id == id);
            return View("Details", dept);
        }
    }
}
