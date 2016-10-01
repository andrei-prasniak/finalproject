using VirtualSchool.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace VirtualSchool.DAL
{
    public class CollegeContext : DbContext

    {

        public CollegeContext() : base("CollegeContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course>  Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Timetable> Timetables { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}