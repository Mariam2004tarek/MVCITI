using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day1.Controllers
{
    public class ITIContext:DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<CourseStudents> CourseStudent { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = itimvc; Integrated Security = True; Encrypt = False; Trust Server Certificate = True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseStudents>(c =>
            {
                c.HasKey(s => new { s.StdId, s.CrsId });
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
