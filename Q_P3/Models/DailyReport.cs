using System;
using System.Collections.Generic;

namespace Q2_P3.Models
{
    public partial class DailyReport
    {
        public string Country { get; set; } = null!;
        public DateTime Date { get; set; }
        public int NewCases { get; set; }
        public int? NewDeaths { get; set; }
        public int? TotalCases { get; set; }
        public int? TotalDeaths { get; set; }
    }
}
