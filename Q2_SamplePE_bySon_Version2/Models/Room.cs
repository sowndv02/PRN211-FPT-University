﻿using System;
using System.Collections.Generic;

namespace Q2_SamplePE_bySon_Version2.Models
{
    public partial class Room
    {
        public Room()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
        }

        public int RoomId { get; set; }
        public string? RoomCode { get; set; }
        public int? CampusId { get; set; }
        public int? Capacity { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }

        public virtual Campus? Campus { get; set; }
        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
    }
}
