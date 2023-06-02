using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    public class Menu
    {
        private List<string> opt = new List<string>();
        public Menu()
        {
            opt.Add("Search Employee By ID.");
            opt.Add("Search Employee By Name.");
            opt.Add("Search Employee By Position.");
            opt.Add("Search Employee By baseSalary");
            opt.Add("Search Employee By GetSalary.");
            opt.Add("Print.");
        }
        public void addNewOption(string option)
        {
            opt.Add(option);
        }

        public int PrintMenu()
        {
            Console.WriteLine("==================");
            for (int i = 1; i <= opt.Count; i++)
            {
                Console.WriteLine(i + ". " + opt[i - 1]);
            }
            Console.WriteLine("0. Exits.");
            return Validation.getInt(0, opt.Count, "Input your choice: ");
        }

    }
}
