using Lab1_1;
using System;

namespace Lab1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.ReadData(@"text.txt");
            Menu menu = new Menu();
            int choice;
            do
            {
                choice = menu.PrintMenu();
                switch (choice)
                {
                    case 1:
                        manager.SearchEmployeeByIdUsingMethod();
                        manager.SearchEmployeeByIdUsingQuery();
                        break;
                    case 2:
                        manager.SearchEmployeeByNameUsingMethod();
                        manager.SearchEmployeeByNameUsingQuery();
                        break;
                    case 3:
                        manager.SearchEmployeeByPositionUsingMethod();
                        manager.SearchEmployeeByPositionUsingQuery();
                        break;
                    case 4:
                        manager.SearchEmployeeByBaseSalaryUsingMethod();
                        manager.SearchEmployeeByBaseSalaryUsingQuery();
                        break;
                    case 5:
                        manager.SearchEmployeeByGetSalaryUsingMethod();
                        manager.SearchEmployeeByGetSalaryUsingQuery();
                        break;

                }
            } while (choice != 0);
        }
    }
}
