using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualSchool.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }


    }
}