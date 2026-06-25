using System;

namespace PackageExpressAssignment
{
// This is the main class for the console application.
class Program
{
// This is the Main method where the program starts running.
static void Main(string[] args)
{
// This line displays the required welcome message.
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

```
        // This line asks the user to enter the package weight.
        Console.WriteLine("Please enter the package weight:");

        // This line reads the user's package weight and converts it to a decimal number.
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // This if statement checks if the package weight is greater than 50.
        if (weight > 50)
        {
            // This message displays if the package is too heavy.
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            // This ends the program.
            return;
        }

        // This line asks the user to enter the package width.
        Console.WriteLine("Please enter the package width:");

        // This line reads the package width and converts it to a decimal number.
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // This line asks the user to enter the package height.
        Console.WriteLine("Please enter the package height:");

        // This line reads the package height and converts it to a decimal number.
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // This line asks the user to enter the package length.
        Console.WriteLine("Please enter the package length:");

        // This line reads the package length and converts it to a decimal number.
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // This line adds the package width, height, and length together.
        decimal totalDimensions = width + height + length;

        // This if statement checks if the total dimensions are greater than 50.
        if (totalDimensions > 50)
        {
            // This message displays if the package is too big.
            Console.WriteLine("Package too big to be shipped via Package Express.");

            // This ends the program.
            return;
        }

        // This line calculates the shipping quote.
        decimal quote = (height * width * length * weight) / 100;

        // This line displays the shipping quote as a dollar amount.
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

        // This line thanks the user.
        Console.WriteLine("Thank you!");
    }
}
```

}
