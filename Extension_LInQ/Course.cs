using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_LInQ
{
    public class Course
    {
        public Course() { }

        public Course(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public Course(int id, string title, DateTime startDate)
        {
            Id = id;
            Title = title;
            StartDate = startDate;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }



        public override string ToString()
        {
            return $"ID: {Id}, Name: {Title}, StarDate: {StartDate.ToString("dd-MM-yyyy")}";
        }

        public virtual void ReadDataFromLine(string line)
        {
            string[] items = line.Split("|");
            Id = Convert.ToInt32(items[1]);
            Title = items[2];
            StartDate = DateTime.ParseExact(items[3], "dd-MM-yyyy", null);
        }
    }


}