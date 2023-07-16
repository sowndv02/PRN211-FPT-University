using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Spring23B5
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public DateTime Dob { get; set; }
        public double Salary { get; set; }
        public void ReadDataFromLine(string line)
        {
            string[] items = line.Split("|");
            Id = Convert.ToInt32(items[0]);
            Name = items[1];
            Dob = Convert.ToDateTime(items[2]);
            Salary = Convert.ToDouble(items[3]);
        }

        public string GetLineFromData()
        {
            return $"{Id}|{Name}|{Dob.ToString("dd/MM/yyyy")}|{Salary}";
        }
    }
}
