using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Controllers
{
    public class CourseStudents
    {
        public int Id { get; set; }
        public int Degree { get; set; }
        [ForeignKey("student")]
        public int StdId { get; set; }
        public Student student { get; set; }
        [ForeignKey("course")]
        public int CrsId { get; set; }
        public Course course { get; set; }
    }
}
