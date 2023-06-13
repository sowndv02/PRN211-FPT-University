using System;
using System.Collections.Generic;

namespace Assignment2.Models
{
    public partial class Student
    {
        public Student()
        {
            RollCallBooks = new HashSet<RollCallBook>();
            Courses = new HashSet<Course>();
        }


        public Student(int studentId, string? roll, string? firstName, string? midName, string? lastName, bool? isAbsent = false)
        {
            StudentId = studentId;
            Roll = roll;
            FirstName = firstName;
            MidName = midName;
            LastName = lastName;
            IsAbsent = isAbsent;
        }

        public int StudentId { get; set; }
        public string? Roll { get; set; }
        public string? FirstName { get; set; }
        public string? MidName { get; set; }
        public string? LastName { get; set; }
        public bool? IsAbsent { get; set; }

        public virtual ICollection<RollCallBook> RollCallBooks { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }

    public class StudentData
    {
        public int StudentId { get; set; }
        public string Roll { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAbsent { get; set; }
    }

}
