using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADOModels.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + MidName + " " + LastName;
            }
        }
        public Student(int studentId, string rollNumber, string firstName, string midName, string lastName)
        {
            StudentId = studentId;
            RollNumber = rollNumber;
            FirstName = firstName;
            LastName = lastName;
            MidName = midName;
        }

        public Student(string rollNumber, string firstName, string lastName, string midName)
        {
            RollNumber = rollNumber;
            FirstName = firstName;
            LastName = lastName;
            MidName = midName;
        }
    }
}
