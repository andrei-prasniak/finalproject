using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualSchool.Models
{

        public enum Condition
    {
        New, Used
    }
        public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Condition? Condition { get; set; }


    }
}