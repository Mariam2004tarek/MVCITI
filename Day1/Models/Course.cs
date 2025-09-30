using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Controllers
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinimumDegree { get; set; }
        public int Hours { get; set; }
        [ForeignKey("department")]
        public int DeptId { get; set; }
        public Department department { get; set; }
        public List<CourseStudents> courseStudents { get; set; }
        public Instructor instructor { get; set; }
    }
}
