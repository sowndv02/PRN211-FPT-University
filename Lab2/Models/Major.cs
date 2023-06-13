using System;
using System.Collections.Generic;

namespace Lab2.Models
{
    public partial class Major
    {
        public Major()
        {
        }

        public Major(string code, string title)
        {
            Code = code;
            Title = title;
        }

        public string Code { get; set; } = null!;
        public string Title { get; set; } = null!;

    }
}
