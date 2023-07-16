using System;
using System.Collections.Generic;

namespace Q2_Spring23.Models
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public byte? Grade { get; set; }
        public int? Schoolyear { get; set; }
        public string? Room { get; set; }

        public virtual SchoolYear? SchoolyearNavigation { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
