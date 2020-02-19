//Lina Kaval
//Period 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Employee Tester";

            Console.Write("Enter the employee's name:  ");
            string name = Console.ReadLine();

            Console.Write("\nEnter the employee's salary:  ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter a raise % from 0.0 to 1.0:  ");
            double raise = Convert.ToDouble(Console.ReadLine());
           
            Employee worker = new Employee(name, salary);

            Console.Clear();

            Console.WriteLine("Here is your employee:");
            Console.WriteLine("name = " + worker.setName() + "\tsalary = " + worker.setSalary());

            worker.raiseSalary(raise);
            Console.WriteLine("\nAfter giving her/him a " + raise * 100 +"% raise, s/he now makes \n" + worker.setSalary());

            Console.Write("\n\nEnter a new name for the employee:  ");
            name = Console.ReadLine();
            worker.newEmployeeName(name);

            Console.Write("\nEnter the employee's new salary:  ");
            salary = Convert.ToDouble(Console.ReadLine());
            worker.newEmployeeSalary(salary);

            Console.WriteLine("\nAfter changing her/his name and wage, s/he now looks like this: ");
            Console.WriteLine("name = " + worker.setName() + "\tsalary = " + worker.setSalary() + "\n\n");
        }
    }
}
