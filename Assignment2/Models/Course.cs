using System;
using System.Collections.Generic;

namespace Assignment2.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
            Students = new HashSet<Student>();
        }

        public int CourseId { get; set; }
        public string? CourseCode { get; set; }
        public string? CourseDescription { get; set; }
        public int SubjectId { get; set; }
        public int? InstructorId { get; set; }
        public int? TermId { get; set; }
        public int? CampusId { get; set; }

        public virtual Instructor? Instructor { get; set; }
        public virtual Subject Subject { get; set; } = null!;
        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
