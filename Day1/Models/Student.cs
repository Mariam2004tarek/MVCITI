using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Controllers
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }
        public char? Grade { get; set; }
        [ForeignKey("department")]
        public int DeptId { get; set; }
        public Department department { get; set; }
        public List<CourseStudents> courseStudents { get; set; }
    }
}
