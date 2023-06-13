using System;
using System.Collections.Generic;

namespace Lab2.Models
{
    public partial class Student
    {
        public Student(string id, string name, bool gender, DateTime dob, double scholarship, bool active, Major majorStudent)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Dob = dob;
            Scholarship = scholarship;
            Active = active;
            MajorStudent = majorStudent;
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Major { get; set; } = null!;
        public double Scholarship { get; set; }
        public bool Active { get; set; }
        
        public string MajorTitle { get { return MajorStudent.Title; } } 

        public virtual Major MajorStudent { get; set; }

        
    }
}
