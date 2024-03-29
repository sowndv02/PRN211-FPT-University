﻿using System;
using System.Collections.Generic;

namespace Q2_SamplePE_bySon_Version2.Models
{
    public partial class Campus
    {
        public Campus()
        {
            Courses = new HashSet<Course>();
            Rooms = new HashSet<Room>();
        }

        public int CampusId { get; set; }
        public string? CampusCode { get; set; }
        public string? CampusName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
