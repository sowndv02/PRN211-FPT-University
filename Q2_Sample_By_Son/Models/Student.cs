using System;
using System.Collections.Generic;

namespace Q2_Sample_By_Son.Models
{
    public partial class Student
    {
        public Student()
        {
            RollCallBooks = new HashSet<RollCallBook>();
            Courses = new HashSet<Course>();
        }

        public int StudentId { get; set; }
        public string? Roll { get; set; }
        public string? FirstName { get; set; }
        public string? MidName { get; set; }
        public string? LastName { get; set; }

        public virtual ICollection<RollCallBook> RollCallBooks { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
