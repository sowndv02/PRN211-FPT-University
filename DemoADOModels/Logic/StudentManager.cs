using DemoADOModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADOModels.Logic
{
    public class StudentManager
    {
        public static List<Student> SearchStudent(List<Student> students, string searchText)
        {
            var list = students.Where(x =>
                x.MidName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                x.FirstName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                x.LastName.Contains(searchText, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            return list;    
        }
    }
}
