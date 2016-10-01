using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualSchool.Models
{
    public class Timetable
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public DateTime Schedule { get; set; }
        public string Tutor { get; set; }

        public virtual Course Course { get; set; }
    }
}