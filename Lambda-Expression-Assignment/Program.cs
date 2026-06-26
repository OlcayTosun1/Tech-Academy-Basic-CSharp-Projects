using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssignment
{
    // This class represents an employee.
    public class Employee
    {
        // This property stores the employee's ID number.
        public int Id { get; set; }

        // This property stores the employee's first name.
        public string FirstName { get; set; }

        // This property stores the employee's last name.
        public string LastName { get; set; }
    }

    // This is the main program class.
    class Program
    {
        // This is the Main method where the console application starts.
        static void Main(string[] args)
        {
            // This creates a list of 10 employees.
            List<Employee> employees = new List<Employee>()
            {
                // These are employee objects with Id, FirstName, and LastName values.
                new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee() { Id = 2, FirstName = "Sarah", LastName = "Johnson" },
                new Employee() { Id = 3, FirstName = "Michael", LastName = "Brown" },
                new Employee() { Id = 4, FirstName = "Joe", LastName = "Williams" },
                new Employee() { Id = 5, FirstName = "Emily", LastName = "Davis" },
                new Employee() { Id = 6, FirstName = "David", LastName = "Miller" },
                new Employee() { Id = 7, FirstName = "Jessica", LastName = "Wilson" },
                new Employee() { Id = 8, FirstName = "Daniel", LastName = "Moore" },
                new Employee() { Id = 9, FirstName = "Laura", LastName = "Taylor" },
                new Employee() { Id = 10, FirstName = "James", LastName = "Anderson" }
            };

            // This creates a new list to store employees with the first name Joe.
            List<Employee> joesUsingForeach = new List<Employee>();

            // This foreach loop checks every employee in the employees list.
            foreach (Employee employee in employees)
            {
                // This if statement checks if the employee's first name is Joe.
                if (employee.FirstName == "Joe")
                {
                    // This adds the employee to the new list if their first name is Joe.
                    joesUsingForeach.Add(employee);
                }
            }

            // This displays the employees named Joe found using the foreach loop.
            Console.WriteLine("Employees named Joe using foreach loop:");

            // This foreach loop prints each employee in the joesUsingForeach list.
            foreach (Employee employee in joesUsingForeach)
            {
                // This displays the employee's ID, first name, and last name.
                Console.WriteLine(employee.Id + " " + employee.FirstName + " " + employee.LastName);
            }

            // This adds a blank line to make the output easier to read.
            Console.WriteLine();

            // This uses a lambda expression to create a list of employees with the first name Joe.
            List<Employee> joesUsingLambda = employees.Where(employee => employee.FirstName == "Joe").ToList();

            // This displays the employees named Joe found using the lambda expression.
            Console.WriteLine("Employees named Joe using lambda expression:");

            // This foreach loop prints each employee in the joesUsingLambda list.
            foreach (Employee employee in joesUsingLambda)
            {
                // This displays the employee's ID, first name, and last name.
                Console.WriteLine(employee.Id + " " + employee.FirstName + " " + employee.LastName);
            }

            // This adds a blank line to make the output easier to read.
            Console.WriteLine();

            // This uses a lambda expression to create a list of employees with an Id greater than 5.
            List<Employee> employeesWithIdGreaterThanFive = employees.Where(employee => employee.Id > 5).ToList();

            // This displays the employees with an Id number greater than 5.
            Console.WriteLine("Employees with Id greater than 5:");

            // This foreach loop prints each employee whose Id is greater than 5.
            foreach (Employee employee in employeesWithIdGreaterThanFive)
            {
                // This displays the employee's ID, first name, and last name.
                Console.WriteLine(employee.Id + " " + employee.FirstName + " " + employee.LastName);
            }

            // This keeps the console window open until the user presses Enter.
            Console.ReadLine();
        }
    }
}
