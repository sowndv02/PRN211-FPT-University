using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Logic
{
    internal class StudentManager
    {
        public static string ConvertRollNumber(int studentId)
        {
            string rollNumberPrefix = "SE";
            string rollNumber = rollNumberPrefix + studentId.ToString("D5");

            return rollNumber;
        }

        public static int CalculateAge(DateTime dateOfBirth)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - dateOfBirth.Year;

            if (currentDate < dateOfBirth.AddYears(age))
            {
                age--;
            }

            return age;
        }


        public static string GetNextStudentId(string currentStudentId)
        {
            string numericPart = currentStudentId.Substring(2);
            int nextNumericPart = int.Parse(numericPart) + 1;
            string nextStudentId = currentStudentId.Substring(0, 2) + nextNumericPart.ToString().PadLeft(numericPart.Length, '0');
            return nextStudentId;
        }

    }
}
