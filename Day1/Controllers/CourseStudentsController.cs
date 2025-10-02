using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class CourseStudentsController : Controller
    {
        ITIContext db = new ITIContext();
        public IActionResult Index()
        {
            List<CourseStudents> crs_std = db.CourseStudent.ToList();
            return View("index",crs_std);
        }
        public IActionResult Details(int id)
        {
            CourseStudents crs_std = db.CourseStudent.FirstOrDefault(a => a.Id == id);
            return View("Details", crs_std);
        }
    }
}
