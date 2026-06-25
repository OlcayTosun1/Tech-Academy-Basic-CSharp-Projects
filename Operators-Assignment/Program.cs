using System;

namespace OperatorsAssignment
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

        // This overloads the == operator so two Employee objects can be compared by their Id.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // This checks if both employee objects are the exact same object.
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            // This checks if either employee object is null.
            if (employee1 is null || employee2 is null)
            {
                return false;
            }

            // This compares the Id property of both employees.
            return employee1.Id == employee2.Id;
        }

        // This overloads the != operator because comparison operators must be overloaded in pairs.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // This returns the opposite result of the == operator.
            return !(employee1 == employee2);
        }

        // This overrides the Equals method so it compares Employee objects correctly.
        public override bool Equals(object obj)
        {
            // This checks if the object is an Employee and compares the Id values.
            return obj is Employee employee && this.Id == employee.Id;
        }

        // This overrides GetHashCode because Equals was overridden.
        public override int GetHashCode()
        {
            // This returns the hash code of the employee Id.
            return Id.GetHashCode();
        }
    }

    // This is the main program class.
    class Program
    {
        // This is the Main method where the console application starts.
        static void Main(string[] args)
        {
            // This creates the first Employee object and assigns values to its properties.
            Employee employee1 = new Employee()
            {
                Id = 101,
                FirstName = "Olcay",
                LastName = "Tosun"
            };

            // This creates the second Employee object and assigns values to its properties.
            Employee employee2 = new Employee()
            {
                Id = 101,
                FirstName = "John",
                LastName = "Smith"
            };

            // This compares the two Employee objects using the overloaded == operator.
            bool areEqual = employee1 == employee2;

            // This compares the two Employee objects using the overloaded != operator.
            bool areNotEqual = employee1 != employee2;

            // This displays the result of the == comparison.
            Console.WriteLine("Are the two employees equal by Id? " + areEqual);

            // This displays the result of the != comparison.
            Console.WriteLine("Are the two employees not equal by Id? " + areNotEqual);

            // This keeps the console window open until the user presses Enter.
            Console.ReadLine();
        }
    }
}
