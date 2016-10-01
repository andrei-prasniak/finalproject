using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualSchool.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Timetable>  Timetables { get; set; }

    }
}