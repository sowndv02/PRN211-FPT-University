using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    class Manager
    {
        public List<Employee> employees = new List<Employee>();
        public Manager() { }

        public void SearchEmployeeByIdUsingMethod()
        {
            Console.WriteLine("Search Employee By ID Using Query");

            int id = Validation.getInt(1, 100, "Input id:");
            var e = employees.First(x => x.Id == id);
            SalaryCalculation obj = GetSalary;
            e.Display(obj);
        }

        public void SearchEmployeeByIdUsingQuery()
        {
            Console.WriteLine("Search Employee By ID Using Query");

            int id = Validation.getInt(1, 100, "Input id:");
            var employee = (from e in employees
                            where e.Id == id
                            select e).First();

            SalaryCalculation obj = GetSalary;
            employee.Display(obj);
        }

        public void SearchEmployeeByNameUsingMethod()
        {
            Console.WriteLine("Search Employee By Name Using Method");

            string name = Validation.getString(1, 60, "Input name:");
            var result = employees.Where(x => x.Name.Contains(name)).ToList();
            foreach (var e in result)
            {
                SalaryCalculation obj = GetSalary;
                e.Display(obj);
            }
        }

        public void SearchEmployeeByNameUsingQuery()
        {
            Console.WriteLine("Search Employee By Name Using Query");

            string name = Validation.getString(1, 60, "Input name:");
            var result = (from e in employees
                          where e.Name.Contains(name)
                          select e
                    ).ToList();
            foreach (var e in result)
            {
                SalaryCalculation obj = GetSalary;
                e.Display(obj);
            }
        }

        public void SearchEmployeeByPositionUsingMethod()
        {
            Console.WriteLine("Search Employee By Position Using Method");

            string position = Validation.getString(1, 20, "Input Position:");
            var result = employees.Where(x => x.Position.Contains(position)).ToList();
            foreach (var e in result)
            {
                SalaryCalculation obj = GetSalary;
                e.Display(obj);
            }
        }

        public void SearchEmployeeByPositionUsingQuery()
        {
            Console.WriteLine("Search Employee By Position Using Query");

            string position = Validation.getString(1, 20, "Input Position:");
            var result = (from e in employees
                          where e.Position.Contains(position)
                          select e
                    ).ToList();

            foreach (var e in result)
            {
                SalaryCalculation obj = GetSalary;
                e.Display(obj);
            }
        }

        public void SearchEmployeeByBaseSalaryUsingMethod()
        {
            Console.WriteLine("Search Employee By BaseSalary Using Method");
            double max = Validation.getDouble(1, 10000, "Input Max: ");
            double min = Validation.getDouble(1, 100, "Input Min:");
            var result = employees.Where(x => x.Salary <= max && x.Salary >= min).ToList();
            foreach (var e in result)
            {
                SalaryCalculation obj = GetSalary;
                e.Display(obj);
            }
        }

        public void SearchEmployeeByBaseSalaryUsingQuery()
        {
            Console.WriteLine("Search Employee By BaseSalary Using Query");
            double max = Validation.getDouble(1, 10000, "Input Max: ");
            double min = Validation.getDouble(1, 100, "Input Min:");
            var result = (from e in employees
                          where e.Salary <= max && e.Salary >= min
                          select e).ToList();

            foreach (var e in result)
            {
                SalaryCalculation deleobj = GetSalary;
                e.Display(deleobj);
            }
        }

        public void SearchEmployeeByGetSalaryUsingMethod()
        {
            SalaryCalculation deleobj = GetSalary;
            Console.WriteLine("Search Employee By GetSalary Using Method");
            double max = Validation.getDouble(1, 10000, "Input Max: ");
            double min = Validation.getDouble(1, 100, "Input Min:");

            var result = employees.Where(x => x.GetSalary(deleobj) >= min && x.GetSalary(deleobj) <= max).ToList();

            foreach (var e in result)
            {
                e.Display(deleobj);
            }
        }

        public void SearchEmployeeByGetSalaryUsingQuery()
        {
            Console.WriteLine("Search Employee By GetSalary Using Query");
            double max = Validation.getDouble(1, 10000, "Input Max: ");
            double min = Validation.getDouble(1, 100, "Input Min:");
            SalaryCalculation obj = GetSalary;
            var result = (from e in employees
                          where e.GetSalary(obj) <= max && e.GetSalary(obj) >= min
                          select e).ToList();
            foreach (var e in result)
            {
                e.Display(obj);
            }
        }


        public void ReadData(string fileName)
        {
            // Read the objects from the file
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Employee e = new Employee();
                        e.ReadDataFromLine(line);
                        employees.Add(e);
                    }
                    sr.Close();
                }
                Console.WriteLine("Read data successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        double GetSalary(double baseSalary, string position)
        {
            if (position == null) return baseSalary;
            if (position.Equals("Manager")) return baseSalary * 16;
            if (position.Equals("Developer")) return baseSalary * 14;
            if (!position.Equals("Manager") && !position.Equals("Developer")) return baseSalary * 12;
            return baseSalary;
        }

        public void Display()
        {
            foreach (Employee obj in employees)
            {
                SalaryCalculation del = GetSalary;
                obj.Display(del);
            }
        }
    }
}
