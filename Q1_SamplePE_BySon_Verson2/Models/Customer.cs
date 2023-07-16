using System;
using System.Collections.Generic;

namespace Q1_SamplePE_BySon_Verson2.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; } = null!;
        public bool? Gender { get; set; }
        public string? Gender2 { get; set; }
    }
}
