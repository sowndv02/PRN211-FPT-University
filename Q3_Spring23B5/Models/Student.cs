using System;
using System.Collections.Generic;

namespace Q3_Spring23B5.Models
{
    public partial class Student
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Major { get; set; } = null!;
        public double Scholarship { get; set; }
        public bool Active { get; set; }

        public virtual Major MajorNavigation { get; set; } = null!;
    }
}
