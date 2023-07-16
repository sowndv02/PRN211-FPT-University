using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_PE_Fall21B5.Model
{
    internal class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Sex { get; set; }
        public string Position { get; set; }
        public int Department { get; set; }
        public string DepartmentName { get; set; }

        public Employee() { }

        public Employee(int id, string name, DateTime dob, string sex, string position, int department, string deparmentName)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Sex = sex;
            Position = position;
            Department = department;
            DepartmentName = deparmentName;
        }
    }
}
