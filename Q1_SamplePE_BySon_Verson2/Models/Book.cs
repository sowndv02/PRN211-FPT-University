using System;
using System.Collections.Generic;

namespace Q1_SamplePE_BySon_Verson2.Models
{
    public partial class Book
    {
        public string Isbn { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int? Edition { get; set; }
        public int? PublishedYear { get; set; }
    }
}
