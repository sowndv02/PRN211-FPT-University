﻿using System;
using System.Collections.Generic;

namespace Q3_SamplePE_BySon_Version2.Models
{
    public partial class Department
    {
        public Department()
        {
            Instructors = new HashSet<Instructor>();
            Subjects = new HashSet<Subject>();
        }

        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
