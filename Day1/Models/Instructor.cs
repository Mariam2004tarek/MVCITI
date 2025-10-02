using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Controllers
{
    public class Instructor
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        [ForeignKey("department")]
        public int DeptId { get; set; }
        public Department department { get; set; }
        [ForeignKey("course")]
        public int CrsId { get; set; }
        public Course course { get; set; }
    }
}
