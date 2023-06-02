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
                        break;
                    case 2:
                        manager.SearchEmployeeByNameUsingMethod();
                        break;
                    case 3:
                        manager.SearchEmployeeByPositionUsingMethod();
                        break;
                    case 4:
                        manager.SearchEmployeeByBaseSalaryUsingMethod();
                        break;
                    case 5:
                        manager.SearchEmployeeByGetSalaryUsingMethod();
                        break;
                    case 6:
                        manager.Display();
                        break;

                }
            } while (choice != 0);
        }
    }
}
