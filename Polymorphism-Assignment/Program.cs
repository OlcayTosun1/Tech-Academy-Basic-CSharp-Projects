using System;

namespace PolymorphismAssignment
{
    // This interface defines a contract for any class that can use the Quit method.
    public interface IQuittable
    {
        // This void method does not return anything.
        void Quit();
    }

    // This Employee class inherits from the IQuittable interface.
    public class Employee : IQuittable
    {
        // This property stores the employee's first name.
        public string FirstName { get; set; }

        // This property stores the employee's last name.
        public string LastName { get; set; }

        // This method implements the Quit method from the IQuittable interface.
        public void Quit()
        {
            // This line displays a message showing that the employee has quit.
            Console.WriteLine(FirstName + " " + LastName + " has quit the company.");
        }
    }

    // This is the main program class.
    class Program
    {
        // This is the Main method where the console application starts.
        static void Main(string[] args)
        {
            // This creates an Employee object, but stores it as the interface type IQuittable.
            IQuittable employee = new Employee()
            {
                // This sets the employee's first name.
                FirstName = "Olcay",

                // This sets the employee's last name.
                LastName = "Tosun"
            };

            // This calls the Quit method using polymorphism.
            employee.Quit();

            // This keeps the console window open until the user presses Enter.
            Console.ReadLine();
        }
    }
}
