using Microsoft.EntityFrameworkCore;
using StudentInfo.Model;

namespace StudentInfo.Data
{
    public class StudentDBContext:DbContext 
    {

        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options) { }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}
