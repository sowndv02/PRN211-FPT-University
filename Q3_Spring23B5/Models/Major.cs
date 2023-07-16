using System;
using System.Collections.Generic;

namespace Q3_Spring23B5.Models
{
    public partial class Major
    {
        public Major()
        {
            Students = new HashSet<Student>();
        }

        public string Code { get; set; } = null!;
        public string Title { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
