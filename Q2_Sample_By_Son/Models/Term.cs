using System;
using System.Collections.Generic;

namespace Q2_Sample_By_Son.Models
{
    public partial class Term
    {
        public Term()
        {
            Courses = new HashSet<Course>();
        }

        public int TermId { get; set; }
        public string? TermName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
