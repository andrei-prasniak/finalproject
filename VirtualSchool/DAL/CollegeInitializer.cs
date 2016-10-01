using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using VirtualSchool.Models;

namespace VirtualSchool.DAL

{
    public class CollegeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CollegeContext>
    {
        protected override void Seed(CollegeContext context)
        {
            var students = new List<Student>
            {
            new Student{LastName="Johnsonson",FirstName="Alexander", Address="80 Renmore Park",Town="Cork"},
            new Student{LastName="Murphy",FirstName="Patrick", Address="51 Tullyglas Street",Town="Limerick"},
            new Student{LastName="Prasniak",FirstName="Andrei", Address="51 Tullyglas Court",Town="Shannon"}
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
            new Course {Name="Web Applications Development" },
            new Course {Name="Ruby on Rails" },
            new Course {Name="Employability" },
            new Course {Name="IT Virtualization" }
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment {FeePaid=true, StudentID=3,CourseID=1 },
            new Enrollment {FeePaid=true, StudentID=2,CourseID=2 },
            new Enrollment {FeePaid=true, StudentID=1,CourseID=2 },
            new Enrollment {FeePaid=true, StudentID=3,CourseID=4 }
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

            var books = new List<Book>
            {
            new Book {Title="Economics", Author="Adams", Condition=Condition.New },
            new Book {Title="Programming", Author="Roberts", Condition=Condition.New },
            new Book {Title="Accounting", Author="Major", Condition=Condition.Used }
            };
            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

            var timetables = new List<Timetable>
            {
            new Timetable {CourseID=1, Schedule= DateTime.Parse("2016-09-01"),Tutor="Burke" },
            new Timetable {CourseID=2, Schedule= DateTime.Parse("2016-09-02"),Tutor="Holmes" },
            new Timetable {CourseID=3, Schedule= DateTime.Parse("2016-09-03"),Tutor="Farrell" }

            };
            timetables.ForEach(s => context.Timetables.Add(s));
            context.SaveChanges();
        }
    }
}