using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1_1
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }
        public string Position { get; set; }

        public Employee(int id, string name, double salary, string position)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Position = position;
        }

        public Employee() { }

        public virtual void ReadDataFromLine(string line)
        {
            string[] items = line.Split("|");
            Id = Convert.ToInt32(items[0]);
            Name = items[1];
            Salary = Convert.ToDouble(items[2]);
            Position = items[3];
        } 
        public void Input()
        {
            Id = Validation.getInt(1, 100, "Input Id:");
            Name = Validation.getString(2, 100, "Input Name: ");
            Salary = Validation.getDouble(0, 100, "Input Salary: ");
            Position = Validation.getString(1, 100, "Input position: ");
        }

        public double GetSalary(SalaryCalculation deleobj)
        {
            return deleobj(Salary, Position);
        }

        public void Display(SalaryCalculation deleobj)
        {
            Console.WriteLine($"{ToString()}, Salary: " + $"{GetSalary(deleobj)}");
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, BaseSalary: {Salary}";
        }
    }


    
}
