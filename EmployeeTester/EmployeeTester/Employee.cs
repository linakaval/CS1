using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTester
{
    class Employee
    {
        private string myName;
        private double mySalary;

        /// <summary>
        /// Constructs an Employee object
        /// </summary>
        /// <param name="aName">The employee's name</param>
        /// <param name="aSalary">The employee's salary</param>
        public Employee(string aName, double aSalary)
        {
            myName = aName;
            mySalary = aSalary;

        }

        /// <summary>
        /// Gets the name of the employee from the user.
        /// </summary>
        /// <returns>The name of the employee.</returns>
        public string setName()
        {
            return myName;
        }

        /// <summary>
        /// Gets the salary of the employee from the user and returns it.
        /// </summary>
        /// <returns>The salary of the employee.</returns>
        public double setSalary()
        {
            return mySalary;
        }

        /// <summary>
        /// Raises the salary by the percentage given by the user
        /// </summary>
        /// <param name="byPercent">The percent of the raise in the form of a decimal</param>
        public void raiseSalary(double byPercent)
        {
            mySalary += mySalary * byPercent;
        }

        /// <summary>
        /// Gets a new employee name from the user.
        /// </summary>
        /// <param name="newName">A new employee's name</param>
        public void newEmployeeName(string newName)
        {
            myName = newName;
        }

        /// <summary>
        /// Gets a new employee salary from the user.
        /// </summary>
        /// <param name="newSalary">A new employee's salary</param>
        public void newEmployeeSalary(double newSalary)
        {
            mySalary = newSalary;
        }
    }
}