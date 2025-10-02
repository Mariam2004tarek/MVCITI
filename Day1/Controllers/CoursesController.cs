using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day1.Controllers
{
    public class CoursesController : Controller
    {
        ITIContext db = new ITIContext();
        public IActionResult Index()
        {
            List<Course> crs = db.Course.ToList();
            return View("index",crs);
        }
        public IActionResult Details(int id)
        {
            Course crs = db.Course.FirstOrDefault(a => a.Id == id);
            return View("Details", crs);
        }

    }
}
