using System;

namespace MethodClassAssignment
{
// This class contains a method that performs a math operation.
public class MathOperation
{
// This void method takes two integer parameters.
public void DoMath(int firstNumber, int secondNumber)
{
// This line performs a math operation on the first integer.
int result = firstNumber * 2;

```
        // This line displays the result of the math operation.
        Console.WriteLine("The first number multiplied by 2 is: " + result);

        // This line displays the second integer to the screen.
        Console.WriteLine("The second number is: " + secondNumber);
    }
}

// This is the main program class.
class Program
{
    // The Main method is where the console application starts.
    static void Main(string[] args)
    {
        // This line creates an object of the MathOperation class.
        MathOperation mathObject = new MathOperation();

        // This line calls the method and passes in two numbers normally.
        mathObject.DoMath(10, 25);

        // This line adds a blank line to make the output easier to read.
        Console.WriteLine();

        // This line calls the method again, specifying the parameters by name.
        mathObject.DoMath(firstNumber: 8, secondNumber: 40);

        // This line keeps the console window open until the user presses Enter.
        Console.ReadLine();
    }
}
```

}
